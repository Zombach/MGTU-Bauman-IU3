using MgtuBaumanIu3.Core;

namespace MgtuBaumanIu3.Merkelov.Task8;

/// <summary>
/// Поиск номеров с ошибкой. 
/// У большинства правовых актов или судебных решений есть определенный
/// регистрационный номер, по которому их просто находить.
/// При этом номер может состоять из цифр, букв, знаков препинания, примеры.
/// Часто пользователи могут случайно ошибиться при вводе такого сложного
/// номера – забыть поставить тире или пропустить нолик. В архиве «2numbers.rar»
/// находится список всех реально существующих номеров законов и судебных решений,
/// а также запросы, в которых номера были введены с ошибками.
/// Предлагается реализовать алгоритм, который, получая на вход некорректный номер,
/// возвращал один или несколько наиболее похожих на него реальных номеров. 
/// </summary>
public class Quest : BaseQuest
{
    public override void Start()
    {
        Io io = Io.Instance;
        VectorHandler vectorHandler = new();
        List<byte[]> queries = io.GetLines("Source\\номера_запросы.txt");
        List<byte[]> laws = io.GetLines("Source\\номера_законов.txt");
        List<byte[]> decisions = io.GetLines("Source\\номера_судебных_решений.txt");
        vectorHandler.Start(queries.Take(1), laws, decisions);
    }
}