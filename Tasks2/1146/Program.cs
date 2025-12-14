using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        string[] words = predlozhenie.Split(' ');

        int countStartN = 0;
        int countEndR = 0;

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > 0)
            {
                if (words[i][0] == 'н' || words[i][0] == 'Н')
                {
                    countStartN++;
                }

                if (words[i][words[i].Length - 1] == 'р' || words[i][words[i].Length - 1] == 'Р')
                {
                    countEndR++;
                }
            }
        }

        Console.WriteLine($"а) Слов, начинающихся с 'н': {countStartN}");
        Console.WriteLine($"б) Слов, оканчивающихся на 'р': {countEndR}");
    }
}