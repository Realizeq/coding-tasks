using System;
class Program
{
    static void Main()
    {
        int[] giri = { 100, 200, 300, 500, 1000, 1200, 1400, 1500, 2000, 3000 };

        Console.Write("Введите v: ");
        int v = int.Parse(Console.ReadLine());

        int sposobi = 0;

        for (int mask = 0; mask < (1 << 10); mask++)
        {
            int summa = 0;
            for (int i = 0; i < 10; i++)
            {
                if ((mask & (1 << i)) != 0)
                {
                    summa += giri[i];
                }
            }

            if (summa == v)
            {
                sposobi++;
            }
        }

        Console.WriteLine($"Число способов: {sposobi}");
    }
}