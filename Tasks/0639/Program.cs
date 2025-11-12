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

        Console.WriteLine("Месяц с наибольшей зарплатой для каждого работника:");
        for (int rabotnik = 0; rabotnik < 12; rabotnik++)
        {
            int maxZarplata = zarplata[rabotnik, 0];
            int mesyacMax = 1;

            for (int mesyac = 1; mesyac < 3; mesyac++)
            {
                if (zarplata[rabotnik, mesyac] > maxZarplata)
                {
                    maxZarplata = zarplata[rabotnik, mesyac];
                    mesyacMax = mesyac + 1;
                }
            }
            Console.WriteLine($"Работник {rabotnik + 1}: месяц {mesyacMax}");
        }

        Console.WriteLine("Работник с наибольшей зарплатой для каждого месяца:");
        for (int mesyac = 0; mesyac < 3; mesyac++)
        {
            int maxZarplata = zarplata[0, mesyac];
            int rabotnikMax = 1;

            for (int rabotnik = 1; rabotnik < 12; rabotnik++)
            {
                if (zarplata[rabotnik, mesyac] > maxZarplata)
                {
                    maxZarplata = zarplata[rabotnik, mesyac];
                    rabotnikMax = rabotnik + 1;
                }
            }
            Console.WriteLine($"Месяц {mesyac + 1}: работник {rabotnikMax}");
        }
    }
}