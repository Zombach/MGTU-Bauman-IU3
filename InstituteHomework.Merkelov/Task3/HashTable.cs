namespace InstituteHomework.Merkelov.Task3;

public class HashTable
{
    private int _size;
    private int?[] _table;

    public HashTable(int size)
    {
        _size = size;
        _table = Enumerable.Repeat<int?>(null, size).ToArray();
    }

    public void Insert(KeyValuePair<string, int> pair)
    {
        int index = Hash(pair.Key);
        if (index >= _size) { Increase(); }
        while (_table[index] is not null)
        {
            index++;
            if (index >= _size) { Increase(); }
        }
        _table[index] = pair.Value;
    }

    public bool Remove(string key)
    {
        int index = Hash(key);
        if (index >= _size) return false;
        _table[index] = null;
        return true;
    }

    public void View(string message)
    {
        Console.WriteLine(message);
        int index = 0;
        _table.ToList().ForEach(value => Console.WriteLine($"{index++}: {value}"));
    }

    private void Increase()
    {
        int?[] table = new int?[_size + _size / 3 + 1];
        Array.Copy(_table, 0, table, 0, _size);
        _size = table.Length;
        _table = table;
    }

    private int Hash(string key) => key.Length % 20;
}