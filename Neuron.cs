namespace Lab1;

public class Neuron
{
    private readonly double _treshold = 1;
    public double[] Weights { get; set; }

    public Neuron(int numberOfInputs)
    {
        Weights = new double[numberOfInputs];
        for (int i = 0; i < numberOfInputs; i++)
            Weights[i] = 1;
    }

    public double CalculateOutput(double[] inputs)
    {
        double sum = 0;
        for (int i = 0; i < inputs.Length; i++)
            sum += inputs[i] * Weights[i];
        return sum >= _treshold ? 1 : 0;
    }

    public void Train(double[] inputs, double desiredOutput, double learningRate)
    {
        double output = CalculateOutput(inputs);
        double error = desiredOutput - output;
        AdjustWeights(inputs, error, learningRate);
    }

    private void AdjustWeights(double[] inputs, double error, double learningRate)
    {
        for (int i = 0; i < inputs.Length; i++)
            Weights[i] += learningRate * error * inputs[i];
    }
}
