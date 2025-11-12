using System;
class Program
{
    static void Main()
    {
        int[] klassA = new int[11];
        int[] klassB = new int[11];
        int[] klassV = new int[11];
        int[] klassG = new int[11];

        for (int parallel = 0; parallel < 11; parallel++)
        {
            Console.WriteLine($"Параллель {parallel + 1}:");
            Console.Write("Класс А: ");
            klassA[parallel] = int.Parse(Console.ReadLine());
            Console.Write("Класс Б: ");
            klassB[parallel] = int.Parse(Console.ReadLine());
            Console.Write("Класс В: ");
            klassV[parallel] = int.Parse(Console.ReadLine());
            Console.Write("Класс Г: ");
            klassG[parallel] = int.Parse(Console.ReadLine());
        }

        int minKlass = klassA[0];
        for (int i = 0; i < 11; i++)
        {
            if (klassA[i] < minKlass) minKlass = klassA[i];
            if (klassB[i] < minKlass) minKlass = klassB[i];
            if (klassV[i] < minKlass) minKlass = klassV[i];
            if (klassG[i] < minKlass) minKlass = klassG[i];
        }
        Console.WriteLine($"В самом мааленьком классе: {minKlass} учеников");

        int minParallel = 1000;
        for (int i = 0; i < 11; i++)
        {
            int summaParallel = klassA[i] + klassB[i] + klassV[i] + klassG[i];
            if (summaParallel < minParallel) minParallel = summaParallel;
        }
        Console.WriteLine($"Минимальное количество учеников в параллели: {minParallel}");

        int summaA = 0;
        int summaB = 0;
        int summaV = 0;
        int summaG = 0;

        for (int i = 0; i < 11; i++)
        {
            summaA += klassA[i];
            summaB += klassB[i];
            summaV += klassV[i];
            summaG += klassG[i];
        }

        int minSummaKlassov = summaA;
        if (summaB < minSummaKlassov) minSummaKlassov = summaB;
        if (summaV < minSummaKlassov) minSummaKlassov = summaV;
        if (summaG < minSummaKlassov) minSummaKlassov = summaG;

        Console.WriteLine($"Минимальное общее количество по классам: {minSummaKlassov}");
    }
}