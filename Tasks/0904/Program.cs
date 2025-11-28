using System;
class Program
{
    static void Main()
    {
        int[] ochki = { 56, 52, 49, 47, 45, 43, 41, 39, 38, 36, 34, 32, 30, 28, 27, 25, 23, 21, 19, 17 };

        Console.WriteLine("Очки команд:");
        for (int i = 0; i < ochki.Length; i++)
        {
            Console.WriteLine($"{ochki[i]}");
        }

        Console.Write("Введите количество очков команды: ");
        int n = int.Parse(Console.ReadLine());

        int mesto = 0;
        while (mesto < ochki.Length && ochki[mesto] > n)
        {
            mesto++;
        }

        Console.WriteLine($"Команда заняла {mesto + 1} место");
    }
}