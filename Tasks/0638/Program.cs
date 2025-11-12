using System;
class Program
{
    static void Main()
    {
        int[,] zarplata = new int[12, 3];

        for (int rabotnik = 0; rabotnik < 12; rabotnik++)
        {
            Console.WriteLine($"Работник {rabotnik + 1}:");
            for (int mesyac = 0; mesyac < 3; mesyac++)
            {
                Console.Write($"Зарплата за месяц {mesyac + 1}: ");
                zarplata[rabotnik, mesyac] = int.Parse(Console.ReadLine());
            }
        }

        int maxZarplata = zarplata[0, 0];
        for (int rabotnik = 0; rabotnik < 12; rabotnik++)
        {
            for (int mesyac = 0; mesyac < 3; mesyac++)
            {
                if (zarplata[rabotnik, mesyac] > maxZarplata)
                {
                    maxZarplata = zarplata[rabotnik, mesyac];
                }
            }
        }
        Console.WriteLine($"Максимальная зарплата: {maxZarplata}");

        int maxSumma = 0;
        int rabotnikMax = 0;
        for (int rabotnik = 0; rabotnik < 12; rabotnik++)
        {
            int summa = 0;
            for (int mesyac = 0; mesyac < 3; mesyac++)
            {
                summa += zarplata[rabotnik, mesyac];
            }
            if (summa > maxSumma)
            {
                maxSumma = summa;
                rabotnikMax = rabotnik + 1;
            }
        }
        Console.WriteLine($"Работник с наибольшей суммой: {rabotnikMax}");

        int maxMesyacSumma = 0;
        int mesyacMax = 0;
        for (int mesyac = 0; mesyac < 3; mesyac++)
        {
            int summaMesyaca = 0;
            for (int rabotnik = 0; rabotnik < 12; rabotnik++)
            {
                summaMesyaca += zarplata[rabotnik, mesyac];
            }
            if (summaMesyaca > maxMesyacSumma)
            {
                maxMesyacSumma = summaMesyaca;
                mesyacMax = mesyac + 1;
            }
        }
        Console.WriteLine($"Месяц с максимальной общей зарплатой: {mesyacMax}");
    }
}