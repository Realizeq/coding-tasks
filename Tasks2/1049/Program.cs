using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        bool hasA = false;
        int firstA = -1;

        for (int i = 0; i < predlozhenie.Length; i++)
        {
            if (predlozhenie[i] == 'а' || predlozhenie[i] == 'А')
            {
                hasA = true;
                firstA = i + 1;
                break;
            }
        }

        if (hasA)
        {
            Console.WriteLine($"Буква 'а' есть, порядковый номер первой: {firstA}");
        }
        else
        {
            Console.WriteLine("Буквы 'а' нет в предложении");
        }
    }
}