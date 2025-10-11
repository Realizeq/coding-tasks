using System;
class Program
{
    static void Main()
    {
        float km, feet;

        Console.Write("Введите расстояние в километрах: ");
        km = float.Parse(Console.ReadLine());

        Console.Write("Введите расстояние в футах: ");
        feet = float.Parse(Console.ReadLine());

        float kmToMeters = km * 1000;
        float feetToMeters = feet * 0.3048f;

        string result;

        if (kmToMeters < feetToMeters)
        {
            result = "километры";
        }
        else
        {
            result = "футы";
        }

        Console.WriteLine($"Меньшее расстояние: {result}");
    }
}