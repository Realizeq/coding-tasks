using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        int firstE = -1;
        int lastE = -1;

        for (int i = 0; i < predlozhenie.Length; i++)
        {
            if (predlozhenie[i] == 'е' || predlozhenie[i] == 'Е')
            {
                if (firstE == -1)
                {
                    firstE = i + 1;
                }
                lastE = i + 1;
            }
        }

        if (firstE != -1)
        {
            Console.WriteLine($"Порядковый номер первой буквы 'е': {firstE}");
            Console.WriteLine($"Порядковый номер последней буквы 'е': {lastE}");
        }
        else
        {
            Console.WriteLine("В предложении нет буквы 'е'");
        }
    }
}