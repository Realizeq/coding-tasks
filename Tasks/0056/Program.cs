using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите расстояние в сантиметрах: ");
        int sm = Convert.ToInt32(Console.ReadLine());

        int m = sm / 100;

        Console.WriteLine($"Полных метров: {m}");
    }
}