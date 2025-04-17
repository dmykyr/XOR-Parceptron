namespace Lab1;

class FourXORParceptron(double learningRate)
{
    private readonly XORParceptron _parceptron1 = new(learningRate);
    private readonly XORParceptron _parceptron2 = new(learningRate);
    private readonly XORParceptron _parceptron3 = new(learningRate);

    public void Train()
    {
        _parceptron1.Train(Program.XORParceptronTrainingData);
        _parceptron2.Train(Program.XORParceptronTrainingData);
        _parceptron3.Train(Program.XORParceptronTrainingData);
    }

    public double CalculateOutput(double[] inputs)
    {
        if (inputs.Length != 4)
            throw new ArgumentException("Input array must have exactly 4 elements.");

        double result1 = _parceptron1.CalculateOutput([inputs[0], inputs[1]]);
        double result2 = _parceptron2.CalculateOutput([inputs[2], inputs[3]]);
        return _parceptron3.CalculateOutput([result1, result2]);
    }
}
