using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите стоимость 1 кг сыра: ");
        float pricePerKg = float.Parse(Console.ReadLine());

        Console.WriteLine("Вес    Стоимость");

        for (int weight = 50; weight <= 1000; weight += 50)
        {
            float cost = weight * pricePerKg / 1000;
            Console.WriteLine($"{weight,-6} {cost,-10:F2}");
        }
    }
}