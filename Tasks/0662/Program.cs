using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Пары дружественных чисел меньше 50000:");

        for (int chislo1 = 1; chislo1 < 50000; chislo1++)
        {
            int summa1 = 0;
            for (int i = 1; i < chislo1; i++)
            {
                if (chislo1 % i == 0)
                {
                    summa1 += i;
                }
            }

            if (summa1 > chislo1 && summa1 < 50000)
            {
                int summa2 = 0;
                for (int i = 1; i < summa1; i++)
                {
                    if (summa1 % i == 0)
                    {
                        summa2 += i;
                    }
                }

                if (summa2 == chislo1)
                {
                    Console.WriteLine($"{chislo1} и {summa1}");
                }
            }
        }
    }
}