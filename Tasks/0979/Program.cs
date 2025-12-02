using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово: ");
        string word = Console.ReadLine();

        Console.Write("Введите номер символа k: ");
        int k = int.Parse(Console.ReadLine());

        if (k > 0 && k <= word.Length)
        {
            char simvol = word[k - 1];
            Console.WriteLine($"Символ номер {k}: {simvol}");
        }
        else
        {
            Console.WriteLine("Нет такого символа");
        }
    }
}