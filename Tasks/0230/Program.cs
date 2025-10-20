using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите точку x: ");
        float x = float.Parse(Console.ReadLine());

        string oblast;

        if (x < 1)
        {
            oblast = "I";
        }
        else if (x > 5)
        {
            oblast = "III";
        }
        else
        {
            oblast = "II";
        }

        Console.WriteLine($"Точка находится в {oblast} области");
    }
}