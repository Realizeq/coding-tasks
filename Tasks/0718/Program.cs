using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();

        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        int b = int.Parse(Console.ReadLine());

        int[] massiv = new int[n];

        for (int i = 0; i < n; i++)
        {
            massiv[i] = rand.Next(a, b + 1);
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"[{i}] = {massiv[i]}");
        }
    }
}