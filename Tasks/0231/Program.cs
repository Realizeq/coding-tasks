using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите y: ");
        float y = float.Parse(Console.ReadLine());

        string region;

        if (y > 5.0f)
        {
            region = "I";
        }
        else if (y > 2.5f)
        {
            region = "II";
        }
        else
        {
            region = "III";
        }

        Console.WriteLine($"Точка находится в {region}");
    }
}