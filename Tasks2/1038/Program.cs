using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        int lastC = -1;
        int lastT = -1;

        for (int i = 0; i < predlozhenie.Length; i++)
        {
            if (predlozhenie[i] == 'с' || predlozhenie[i] == 'С')
            {
                lastC = i;
            }
            else if (predlozhenie[i] == 'т' || predlozhenie[i] == 'Т')
            {
                lastT = i;
            }
        }

        if (lastC > lastT)
        {
            Console.WriteLine($"Буква 'с' встречается позже: позиция {lastC + 1}");
        }
        else if (lastT > lastC)
        {
            Console.WriteLine($"Буква 'т' встречается позже: позиция {lastT + 1}");
        }
        else if (lastC == -1 && lastT == -1)
        {
            Console.WriteLine("В предложении нет букв 'с' и 'т'");
        }
        else
        {
            Console.WriteLine("Буквы 'с' и 'т' встречаются на одной позиции");
        }
    }
}