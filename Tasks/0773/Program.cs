using System;
class Program
{
    static void Main()
    {
        int[] osadki = { 45, 38, 52, 67, 89, 75, 92, 84, 58, 63, 71, 49 };

        int summa = osadki[2] + osadki[5] + osadki[8] + osadki[11];

        Console.WriteLine($"Осадки в марте, июне, сентябре и декабре: {summa}");
    }
}