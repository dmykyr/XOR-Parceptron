namespace Lab1;

public class XORParceptron(double learningRate)
{
    private readonly Neuron _neuron1 = new(2);
    private readonly Neuron _neuron2 = new(2);
    private readonly Neuron _neuron3 = new(2);

    public void Train(List<List<TrainingData>> trainingData)
    {
        TrainNeuron(_neuron1, trainingData[0]);
        TrainNeuron(_neuron2, trainingData[1]);
        TrainNeuron(_neuron3, trainingData[2]);
    }

    public double CalculateOutput(double[] inputs)
    {
        double result1 = _neuron1.CalculateOutput(inputs);
        double result2 = _neuron2.CalculateOutput(inputs);
        return _neuron3.CalculateOutput([result1, result2]);
    }

    private void TrainNeuron(Neuron neuron, List<TrainingData> trainingData)
    {
        double totalError = 1;

        while (totalError != 0)
        {
            totalError = 0;

            foreach (var data in trainingData)
            {
                double result = neuron.CalculateOutput(data.Inputs);
                double error = data.DesiredOutput - result;
                totalError += Math.Abs(error);

                if (error != 0)
                {
                    neuron.Train(data.Inputs, data.DesiredOutput, learningRate);
                }
            }
        }
    }
}

