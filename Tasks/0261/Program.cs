using System;
class Program
{
    static void Main()
    {
        double price = 20.4;

        Console.WriteLine("Количество  Стоимость");

        for (int i = 2; i <= 20; i++)
        {
            double cost = i * price;
            Console.WriteLine($"{i,9}  {cost,10:F1} руб.");
        }
    }
}