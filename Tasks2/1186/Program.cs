using System;
class Program
{
    static void Main()
    {
        int[] vozrast = {25, 30, 35, 40, 28, 32, 45, 38, 27, 33,
                        29, 31, 36, 42, 26, 34, 39, 41, 37, 44};

        bool[] pol = {true, true, false, true, false, true, false, true, true, false,
                     true, false, true, false, true, false, true, true, false, true};

        float[] massa = {75, 82, 58, 85, 62, 78, 65, 80, 70, 60,
                        77, 63, 79, 68, 72, 59, 81, 83, 64, 84};

        float massaMuzhchin = 0;

        for (int i = 0; i < 20; i++)
        {
            if (pol[i])
            {
                massaMuzhchin += massa[i];
            }
        }

        Console.WriteLine($"Общая масса мужчин: {massaMuzhchin} кг");
    }
}