using System;
class Program
{
    static void Main()
    {
        int[] veshchi = {2, 1, 3, 2, 4, 1, 3, 2, 1, 5,
                        2, 3, 1, 2, 4, 1, 3, 2, 1, 3,
                        2, 4, 1, 2};

        float[] ves = {35, 20, 45, 30, 60, 15, 50, 35, 18, 70,
                     40, 55, 22, 38, 65, 17, 48, 32, 19, 52,
                     42, 68, 16, 36};

        int countMoreThan2 = 0;
        for (int i = 0; i < 24; i++)
        {
            if (veshchi[i] > 2)
            {
                countMoreThan2++;
            }
        }
        Console.WriteLine($"а) Пассажиров с более чем 2 вещами: {countMoreThan2}");

        bool hasOneLightBaggage = false;
        for (int i = 0; i < 24; i++)
        {
            if (veshchi[i] == 1 && ves[i] < 25)
            {
                hasOneLightBaggage = true;
                break;
            }
        }
        Console.WriteLine($"б) Есть пассажир с одной вещью весом <25 кг: {(hasOneLightBaggage ? "да" : "нет")}");

        int sumVeshchi = 0;
        for (int i = 0; i < 24; i++)
        {
            sumVeshchi += veshchi[i];
        }
        float sredneeVeshchi = sumVeshchi / 24.0f;

        int countAboveAverage = 0;
        for (int i = 0; i < 24; i++)
        {
            if (veshchi[i] > sredneeVeshchi)
            {
                countAboveAverage++;
            }
        }
        Console.WriteLine($"в) Пассажиров с количеством вещей выше среднего: {countAboveAverage}");

        float sumVes = 0;
        for (int i = 0; i < 24; i++)
        {
            sumVes += ves[i];
        }
        float sredniyVes = sumVes / sumVeshchi;

        Console.WriteLine($"г) Багаж со средним весом вещи близким к общему среднему ({sredniyVes:F2} кг):");
        for (int i = 0; i < 24; i++)
        {
            float sredniyVesVeshchi = ves[i] / veshchi[i];
            if (Math.Abs(sredniyVesVeshchi - sredniyVes) <= 0.5)
            {
                Console.WriteLine($"   Пассажир {i + 1}: средний вес вещи {sredniyVesVeshchi:F2} кг");
            }
        }
    }
}