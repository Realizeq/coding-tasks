using System;
class Program
{
    static void Main()
    {
        int[,] ocenki = new int[14, 3];

        for (int student = 0; student < 14; student++)
        {
            Console.WriteLine($"Студент {student + 1}:");
            for (int predmet = 0; predmet < 3; predmet++)
            {
                Console.Write($"Оценка по предмету {predmet + 1}: ");
                ocenki[student, predmet] = int.Parse(Console.ReadLine());
            }
        }

        int bezDvoek = 0;
        for (int student = 0; student < 14; student++)
        {
            bool estDvoyka = false;
            for (int predmet = 0; predmet < 3; predmet++)
            {
                if (ocenki[student, predmet] == 2)
                {
                    estDvoyka = true;
                }
            }
            if (!estDvoyka)
            {
                bezDvoek++;
            }
        }
        Console.WriteLine($"Студентов без двоек: {bezDvoek}");

        int predmetovTolko4i5 = 0;
        for (int predmet = 0; predmet < 3; predmet++)
        {
            bool tolko4i5 = true;
            for (int student = 0; student < 14; student++)
            {
                if (ocenki[student, predmet] != 5 && ocenki[student, predmet] != 4)
                {
                    tolko4i5 = false;
                }
            }
            if (tolko4i5)
            {
                predmetovTolko4i5++;
            }
        }
        Console.WriteLine($"Предметов только с 4 и 5: {predmetovTolko4i5}");

        Console.WriteLine("Количество двоек по каждому предмету:");
        for (int predmet = 0; predmet < 3; predmet++)
        {
            int dvoek = 0;
            for (int student = 0; student < 14; student++)
            {
                if (ocenki[student, predmet] == 2)
                {
                    dvoek++;
                }
            }
            Console.WriteLine($"Предмет {predmet + 1}: {dvoek}");
        }
    }
}