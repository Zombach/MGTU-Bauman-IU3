using MgtuBaumanIu3.Core;

namespace MgtuBaumanIu3.Merkelov.Task5;

/// <summary>
/// Задание:  Вычислить расстояние Дамерау-Левенштейна для следующих пар слов:
/// Аббревиатура и Бабреваитуар, Фуникулер и Уфнниуклер.
/// </summary>
public class Quest : BaseQuest
{
    public override void Start()
    {
        string word1 = "Аббревиатура";
        string word2 = "Бабреваитуар";
        string word3 = "Фуникулер";
        string word4 = "Уфнниуклер";

        int distance1 = ComputeDamerauLevenshteinDistance(word1, word2);
        int distance2 = ComputeDamerauLevenshteinDistance(word3, word4);

        Console.WriteLine($"Расстояние Дамерау-Левенштейна между \"{word1}\" и \"{word2}\": {distance1}");
        Console.WriteLine($"Расстояние Дамерау-Левенштейна между \"{word3}\" и \"{word4}\": {distance2}");
    }

    public int ComputeDamerauLevenshteinDistance(string s1, string s2)
    {
        int[,] d = new int[s1.Length + 1, s2.Length + 1];

        for (int i = 0; i <= s1.Length; i++)
        {
            d[i, 0] = i;
        }

        for (int j = 0; j <= s2.Length; j++)
        {
            d[0, j] = j;
        }

        for (int i = 1; i <= s1.Length; i++)
        {
            for (int j = 1; j <= s2.Length; j++)
            {
                int cost = (s1[i - 1] == s2[j - 1]) ? 0 : 1;

                d[i, j] = Math.Min
                (
                    Math.Min
                    (
                        d[i - 1, j] + 1,
                        d[i, j - 1] + 1
                    ),
                    d[i - 1, j - 1] + cost
                );

                if (i > 1 && j > 1 && s1[i - 1] == s2[j - 2] && s1[i - 2] == s2[j - 1])
                {
                    d[i, j] = Math.Min(d[i, j], d[i - 2, j - 2] + cost);
                }
            }
        }

        return d[s1.Length, s2.Length];
    }
}