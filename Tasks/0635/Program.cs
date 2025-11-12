using System;
class Program
{
    static void Main()
    {
        int[,] ocenki = new int[18, 3];

        for (int uchenik = 0; uchenik < 18; uchenik++)
        {
            Console.WriteLine($"Ученик {uchenik + 1}:");
            for (int predmet = 0; predmet < 3; predmet++)
            {
                Console.Write($"Оценка по предмету {predmet + 1}: ");
                ocenki[uchenik, predmet] = int.Parse(Console.ReadLine());
            }
        }

        int pyaterki = 0;
        for (int uchenik = 0; uchenik < 18; uchenik++)
        {
            for (int predmet = 0; predmet < 3; predmet++)
            {
                if (ocenki[uchenik, predmet] == 5)
                {
                    pyaterki++;
                }
            }
        }
        Console.WriteLine($"Общее количество пятерок: {pyaterki}");

        Console.WriteLine("Количество троек у каждого ученика:");
        for (int uchenik = 0; uchenik < 18; uchenik++)
        {
            int troiki = 0;
            for (int predmet = 0; predmet < 3; predmet++)
            {
                if (ocenki[uchenik, predmet] == 3)
                {
                    troiki++;
                }
            }
            Console.WriteLine($"Ученик {uchenik + 1}: {troiki}");
        }

        Console.WriteLine("Количество двоек по каждому предмету:");
        for (int predmet = 0; predmet < 3; predmet++)
        {
            int dvoiki = 0;
            for (int uchenik = 0; uchenik < 18; uchenik++)
            {
                if (ocenki[uchenik, predmet] == 2)
                {
                    dvoiki++;
                }
            }
            Console.WriteLine($"Предмет {predmet + 1}: {dvoiki}");
        }
    }
}