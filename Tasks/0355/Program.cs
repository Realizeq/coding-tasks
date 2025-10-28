using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        int i = 1;
        while (i * i <= n)
        {
            Console.Write($"{i} ");
            i++;
        }
    }
}