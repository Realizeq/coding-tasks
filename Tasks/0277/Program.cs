using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите стоимость 1 кг конфет: ");
        float price = float.Parse(Console.ReadLine());

        Console.WriteLine("Вес    Стоимость");

        for (int weight = 100; weight <= 2000; weight += 100)
        {
            float cost = weight * price / 1000;
            Console.WriteLine($"{weight,-6} {cost,-10:F2}");
        }
    }
}