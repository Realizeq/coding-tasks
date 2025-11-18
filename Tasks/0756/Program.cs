using System;
class Program
{
    static void Main()
    {
        int[] soprotivlenie = { 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90, 95, 100, 105 };

        int summa = 0;
        for (int i = 0; i < soprotivlenie.Length; i++)
        {
            summa += soprotivlenie[i];
        }

        Console.WriteLine($"Общее сопротивление: {summa}");
    }
}