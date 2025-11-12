using System;
class Program
{
    static void Main()
    {
        float[,] balli = new float[15, 3];

        for (int sportsmen = 0; sportsmen < 15; sportsmen++)
        {
            Console.WriteLine($"Спортсмен {sportsmen + 1}:");
            Console.Write("Обязательная программа: ");
            balli[sportsmen, 0] = float.Parse(Console.ReadLine());
            Console.Write("Короткая программа: ");
            balli[sportsmen, 1] = float.Parse(Console.ReadLine());
            Console.Write("Произвольная программа: ");
            balli[sportsmen, 2] = float.Parse(Console.ReadLine());
        }

        Console.WriteLine("Среднее количество баллов каждого спортсмена:");
        for (int sportsmen = 0; sportsmen < 15; sportsmen++)
        {
            float summa = balli[sportsmen, 0] + balli[sportsmen, 1] + balli[sportsmen, 2];
            float srednee = summa / 3;
            Console.WriteLine($"Спортсмен {sportsmen + 1}: {srednee}");
        }

        Console.WriteLine("Среднее количество баллов по каждому виду:");
        float sredneeObyazatelnaya = 0;
        float sredneeKorotkaya = 0;
        float sredneeProizvolnaya = 0;

        for (int sportsmen = 0; sportsmen < 15; sportsmen++)
        {
            sredneeObyazatelnaya += balli[sportsmen, 0];
            sredneeKorotkaya += balli[sportsmen, 1];
            sredneeProizvolnaya += balli[sportsmen, 2];
        }

        Console.WriteLine($"Обязательная программа: {sredneeObyazatelnaya / 15}");
        Console.WriteLine($"Короткая программа: {sredneeKorotkaya / 15}");
        Console.WriteLine($"Произвольная программа: {sredneeProizvolnaya / 15}");
    }
}