using System.Text;

namespace InstituteHomework.Core;

public class Io
{
    private static readonly Io? InstanceIo;

    public static Io Instance = InstanceIo ??= new Io();

    static Io() => Console.InputEncoding = Encoding.GetEncoding("utf-16");

    public string GetLine(string message)
    {
        Console.WriteLine(message);
        do
        {
            string? line = Console.ReadLine();
            if (line is not null) { return line; }
            Console.WriteLine("Повторите ввод");
        } while (true);
    }

    public List<byte[]> GetLines(string path)
    {
        try
        {
            if (!File.Exists(path)) { throw new Exception("Отсутствует файл по данному пути"); }
            return File.ReadAllLines(path).Select(Encoding.UTF8.GetBytes).ToList();
        }
        catch (Exception e)
        {
            Console.WriteLine($"{e.Message}\r\nОтсутствует файл");
            throw;
        }
    }

    public int[] GetArray(int size, string name)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = GetDigital<int>($"Введите значение для массива {name}");
        }
        return array;
    }

    public KeyValuePair<string, int> GetPair() => new(GetLine("Укажите key:"), GetDigital<int>("Укажите value:"));

    public T GetDigital<T>(string message)
    {
        Console.WriteLine(message);
        do
        {
            string? line = Console.ReadLine();
            bool isParse = Parse(line, out T? result);
            if (isParse && result is not null) { return result; }
            Console.WriteLine("Повторите ввод");
        } while (true);
    }

    private bool Parse<T>(string? source, out T? result)
    {
        result = typeof(T) switch
        {
            _ when typeof(T) == typeof(byte) => byte.TryParse(source, out byte digital) ? (T?)(object)digital : default,
            _ when typeof(T) == typeof(short) => short.TryParse(source, out short digital) ? (T?)(object)digital : default,
            _ when typeof(T) == typeof(int) => int.TryParse(source, out int digital) ? (T?)(object)digital : default,
            _ when typeof(T) == typeof(float) => float.TryParse(source, out float digital) ? (T?)(object)digital : default,
            _ when typeof(T) == typeof(float) => float.TryParse(source, out float digital) ? (T?)(object)digital : default,
            _ => throw new Exception("Не поддерживается тип")
        };
        return result is not null;
    }
}