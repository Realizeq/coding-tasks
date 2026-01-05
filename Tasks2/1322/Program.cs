using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        int i = 1;
        int kvadrat = i * i;

        while (kvadrat <= n)
        {
            i++;
            kvadrat = i * i;
        }

        Console.WriteLine($"Первое число большее {n}: {kvadrat}");
    }
}