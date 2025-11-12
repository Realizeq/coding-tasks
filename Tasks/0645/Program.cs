using System;
class Program
{
    static void Main()
    {
        int[] gruppa1 = new int[5];
        int[] gruppa2 = new int[5];
        int[] gruppa3 = new int[5];
        int[] gruppa4 = new int[5];
        int[] gruppa5 = new int[5];

        for (int kurs = 0; kurs < 5; kurs++)
        {
            Console.WriteLine($"Курс {kurs + 1}:");
            Console.Write("Группа 1: ");
            gruppa1[kurs] = int.Parse(Console.ReadLine());
            Console.Write("Группа 2: ");
            gruppa2[kurs] = int.Parse(Console.ReadLine());
            Console.Write("Группа 3: ");
            gruppa3[kurs] = int.Parse(Console.ReadLine());
            Console.Write("Группа 4: ");
            gruppa4[kurs] = int.Parse(Console.ReadLine());
            Console.Write("Группа 5: ");
            gruppa5[kurs] = int.Parse(Console.ReadLine());
        }

        int minKurs = 1000;
        int kursMin = 1;
        for (int i = 0; i < 5; i++)
        {
            int summaKursa = gruppa1[i] + gruppa2[i] + gruppa3[i] + gruppa4[i] + gruppa5[i];
            if (summaKursa < minKurs)
            {
                minKurs = summaKursa;
                kursMin = i + 1;
            }
        }
        Console.WriteLine($"Меньше всего студентов на курсе {kursMin}: {minKurs}");

        int minGruppa = gruppa1[0];
        int gruppaMin = 1;
        int kursGruppaMin = 1;
        for (int i = 0; i < 5; i++)
        {
            if (gruppa1[i] < minGruppa)
            {
                minGruppa = gruppa1[i];
                gruppaMin = 1;
                kursGruppaMin = i + 1;
            }
            if (gruppa2[i] < minGruppa)
            {
                minGruppa = gruppa2[i];
                gruppaMin = 2;
                kursGruppaMin = i + 1;
            }
            if (gruppa3[i] < minGruppa)
            {
                minGruppa = gruppa3[i];
                gruppaMin = 3;
                kursGruppaMin = i + 1;
            }
            if (gruppa4[i] < minGruppa)
            {
                minGruppa = gruppa4[i];
                gruppaMin = 4;
                kursGruppaMin = i + 1;
            }
            if (gruppa5[i] < minGruppa)
            {
                minGruppa = gruppa5[i];
                gruppaMin = 5;
                kursGruppaMin = i + 1;
            }
        }
        Console.WriteLine($"Самая малочисленная группа: курс {kursGruppaMin}, группа {gruppaMin}: {minGruppa} студентов");

        Console.WriteLine("Самая малочисленная группа для каждого курса:");
        for (int i = 0; i < 5; i++)
        {
            int min = gruppa1[i];
            int gruppa = 1;

            if (gruppa2[i] < min)
            {
                min = gruppa2[i];
                gruppa = 2;
            }
            if (gruppa3[i] < min)
            {
                min = gruppa3[i];
                gruppa = 3;
            }
            if (gruppa4[i] < min)
            {
                min = gruppa4[i];
                gruppa = 4;
            }
            if (gruppa5[i] < min)
            {
                min = gruppa5[i];
                gruppa = 5;
            }

            Console.WriteLine($"Курс {i + 1}: группа {gruppa} - {min} студентов");
        }
    }
}