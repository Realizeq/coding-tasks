using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите x: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Введите y: ");
        int y = int.Parse(Console.ReadLine());

        int product1 = 0;
        for (int i = 0; i < y; i++)
        {
            product1 += x;
        }
        Console.WriteLine($"Способ 1: {product1}");

        int product2 = 0;
        for (int i = 0; i < x; i++)
        {
            product2 += y;
        }
        Console.WriteLine($"Способ 2: {product2}");
    }
}