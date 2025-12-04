using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        Console.Write("Введите символ: ");
        char simvol = Console.ReadLine()[0];

        int count = 0;

        for (int i = 0; i < predlozhenie.Length; i++)
        {
            if (predlozhenie[i] == simvol)
            {
                count++;
            }
        }

        Console.WriteLine($"Символ '{simvol}' встречается {count} раз");
    }
}