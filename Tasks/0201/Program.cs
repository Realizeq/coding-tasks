using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите время в минутах: ");
        float t = float.Parse(Console.ReadLine());

        float cycleTime = t % 6;

        string color;

        if (cycleTime < 3)
        {
            color = "зеленый";
        }
        else if (cycleTime < 4)
        {
            color = "желтый";
        }
        else
        {
            color = "красный";
        }

        Console.WriteLine($"В момент {t} минут горит {color} сигнал");
    }
}