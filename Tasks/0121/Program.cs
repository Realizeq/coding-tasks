using System;
class Program
{
    static void Main()
    {
        float volume1, mass1, volume2, mass2;

        Console.Write("Введите объем первого тела: ");
        volume1 = float.Parse(Console.ReadLine());

        Console.Write("Введите массу первого тела: ");
        mass1 = float.Parse(Console.ReadLine());

        Console.Write("Введите объем второго тела: ");
        volume2 = float.Parse(Console.ReadLine());

        Console.Write("Введите массу второго тела: ");
        mass2 = float.Parse(Console.ReadLine());

        float density1 = mass1 / volume1;
        float density2 = mass2 / volume2;

        string result;

        if (density1 > density2)
        {
            result = "первого";
        }
        else
        {
            result = "второго";
        }

        Console.WriteLine($"Материал плотнее у {result} тела");
    }
}