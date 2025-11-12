using System;
class Program
{
    static void Main()
    {
        int[,] balli = new int[8, 4];

        for (int sportsmen = 0; sportsmen < 8; sportsmen++)
        {
            Console.WriteLine($"Спортсмен {sportsmen + 1}:");
            for (int vid = 0; vid < 4; vid++)
            {
                Console.Write($"Баллы за вид {vid + 1}: ");
                balli[sportsmen, vid] = int.Parse(Console.ReadLine());
            }
        }

        int maxOcenka = balli[0, 0];
        for (int sportsmen = 0; sportsmen < 8; sportsmen++)
        {
            for (int vid = 0; vid < 4; vid++)
            {
                if (balli[sportsmen, vid] > maxOcenka)
                {
                    maxOcenka = balli[sportsmen, vid];
                }
            }
        }
        Console.WriteLine($"Максимальная оценка: {maxOcenka}");

        int pobeditel = 0;
        int maxSumma = 0;
        for (int sportsmen = 0; sportsmen < 8; sportsmen++)
        {
            int summa = 0;
            for (int vid = 0; vid < 4; vid++)
            {
                summa += balli[sportsmen, vid];
            }
            if (summa > maxSumma)
            {
                maxSumma = summa;
                pobeditel = sportsmen + 1;
            }
        }
        Console.WriteLine($"Победитель: спортсмен {pobeditel} с суммой {maxSumma}");
    }
}