using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите вес боксера кг: ");
        float weight = float.Parse(Console.ReadLine());

        string category;

        if (weight < 60)
        {
            category = "легкий вес";
        }
        else if (weight < 64)
        {
            category = "первый полусредний вес";
        }
        else if (weight < 69)
        {
            category = "полусредний вес";
        }
        else
        {
            category = "свыше полусреднего веса";
        }

        Console.WriteLine($"Весовая категория: {category}");
    }
}