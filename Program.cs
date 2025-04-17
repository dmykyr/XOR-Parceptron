namespace Lab1;

internal class Program
{
    static void Main(string[] args)
    {
        var testData = new List<TrainingData>
        {
            new([0, 0, 0, 0], 0),
            new([0, 0, 0, 1], 1),
            new([0, 0, 1, 0], 1),
            new([0, 0, 1, 1], 0),
            new([0, 1, 0, 0], 1),
            new([0, 1, 0, 1], 0),
            new([0, 1, 1, 0], 0),
            new([0, 1, 1, 1], 1),
            new([1, 0, 0, 0], 1),
            new([1, 0, 0, 1], 0),
            new([1, 0, 1, 0], 0),
            new([1, 0, 1, 1], 1),
            new([1, 1, 0, 0], 0),
            new([1, 1, 0, 1], 1),
            new([1, 1, 1, 0], 1),
            new([1, 1, 1, 1], 0)
        };

        FourXORParceptron fourXorNetwork = new(1.5);
        fourXorNetwork.Train();

        Console.WriteLine("Results for 4-input XOR:");
        foreach (var dataCase in testData)
        {
            double output = fourXorNetwork.CalculateOutput(dataCase.Inputs);
            Console.WriteLine($"{dataCase}\t Output: {output}");
        }
    }

    public static List<List<TrainingData>> XORParceptronTrainingData =
    [
        [
            new([0, 0], 0),
            new([0, 1], 1),
            new([1, 0], 0),
            new([1, 1], 0)
        ],
        [
            new([0, 0], 0),
            new([0, 1], 0),
            new([1, 0], 1),
            new([1, 1], 0)
        ],
        [
            new([0, 0], 0),
            new([0, 1], 1),
            new([1, 0], 1),
            new([0, 0], 0)
        ],
    ];
}