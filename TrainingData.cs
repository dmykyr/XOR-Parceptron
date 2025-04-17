namespace Lab1;

public class TrainingData(double[] inputs, double excpectedOutput)
{
    public double[] Inputs { get; } = inputs;
    public double ExpectedOutput { get; } = excpectedOutput;
    public override string ToString()
    {
        return $"Inputs: {string.Join(", ", Inputs)}  Expected: {ExpectedOutput}";
    }
}
