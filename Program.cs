namespace Lab1;

internal class Program
{
    static void Main(string[] args)
    {
        var trainingData = new List<List<TrainingData>>
        {
            new() {
                new([0, 0], 0),
                new([0, 1], 1),
                new([1, 0], 0),
                new([1, 1], 0)
            },
            new() {
                new([0, 0], 0),
                new([0, 1], 0),
                new([1, 0], 1),
                new([1, 1], 0)
            },
            new() {
                new([0, 0], 0),
                new([0, 1], 1),
                new([1, 0], 1),
                new([0, 0], 0)
            },
        };

        XORParceptron xorNetwork = new(1.5);
        xorNetwork.Train(trainingData);

        var data = new List<TrainingData>()
        {
            new([0, 0], 0),
            new([0, 1], 1),
            new([1, 0], 1),
            new([1, 1], 0)
        };

        Console.WriteLine("Results:");
        foreach (var dataCase in data)
        {
            double output = xorNetwork.CalculateOutput(dataCase.Inputs);
            Console.WriteLine($"Input: {dataCase.Inputs[0]}, {dataCase.Inputs[1]} => Output: {output}");
        }
    }
}