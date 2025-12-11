using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        int oCount = 0;
        int aCount = 0;

        for (int i = 0; i < predlozhenie.Length; i++)
        {
            char c = char.ToLower(predlozhenie[i]);
            if (c == 'о')
            {
                oCount++;
            }
            else if (c == 'а')
            {
                aCount++;
            }
        }

        if (oCount > aCount)
        {
            Console.WriteLine($"Буква 'о' встречается чаще: {oCount} против {aCount}");
        }
        else if (aCount > oCount)
        {
            Console.WriteLine($"Буква 'а' встречается чаще: {aCount} против {oCount}");
        }
        else
        {
            Console.WriteLine($"Буквы встречаются одинаково часто: по {oCount} раз");
        }
    }
}