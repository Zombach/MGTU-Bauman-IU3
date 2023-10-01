namespace MgtuBaumanIu3.Vidmanov.Task5.Part6;

public class Survey
{
    private readonly Dictionary<string, string> _answers = new Dictionary<string, string>();

    public void AddAnswer(string question, string answer) => _answers.Add(question, answer);

    public void DisplayResults()
    {
        foreach (var pair in _answers)
        {
            Console.WriteLine($"Question: {pair.Key}");
            Console.WriteLine($"Answer: {pair.Value}");
            Console.WriteLine();
        }
    }
}