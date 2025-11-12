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

        Console.WriteLine("Самый малочисленный класс в каждой параллели:");
        for (int i = 0; i < 11; i++)
        {
            int min = klassA[i];
            if (klassB[i] < min) min = klassB[i];
            if (klassV[i] < min) min = klassV[i];
            if (klassG[i] < min) min = klassG[i];
            Console.WriteLine($"Параллель {i + 1}: {min} учеников");
        }

        int minA = klassA[0];
        int minB = klassB[0];
        int minV = klassV[0];
        int minG = klassG[0];

        for (int i = 1; i < 11; i++)
        {
            if (klassA[i] < minA) minA = klassA[i];
            if (klassB[i] < minB) minB = klassB[i];
            if (klassV[i] < minV) minV = klassV[i];
            if (klassG[i] < minG) minG = klassG[i];
        }

        Console.WriteLine($"Самый малочисленный класс А: {minA}");
        Console.WriteLine($"Самый малочисленный класс Б: {minB}");
        Console.WriteLine($"Самый малочисленный класс В: {minV}");
        Console.WriteLine($"Самый малочисленный класс Г: {minG}");
    }
}