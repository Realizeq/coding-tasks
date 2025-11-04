using System;
class Program
{
    static void Main()
    {
        double total = 0;

        Console.Write("количество товаров: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"товар {i}: ");
            double price = double.Parse(Console.ReadLine());
            if (price > 1000)
            {
                total += price;
            }
        }

        Console.WriteLine($"общая стоимость дорогих товаров: {total}");
    }
}