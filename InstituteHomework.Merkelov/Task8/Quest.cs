using InstituteHomework.Core;

namespace InstituteHomework.Merkelov.Task8;

public class Quest : BaseQuest
{
    public override void Start()
    {
        Io io = Io.Instance;
        VectorHandler vectorHandler = new();
        List<byte[]> queries = io.GetLines("номера_запросы.txt");
        List<byte[]> laws = io.GetLines("номера_законов.txt");
        List<byte[]> decisions = io.GetLines("номера_судебных_решений.txt");
        vectorHandler.Start(queries.Take(1), laws, decisions);
    }
}