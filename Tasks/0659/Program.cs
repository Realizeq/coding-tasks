using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Трехзначные совершенные числа:");

        for (int chislo = 100; chislo <= 999; chislo++)
        {
            int summa = 0;

            for (int i = 1; i < chislo; i++)
            {
                if (chislo % i == 0)
                {
                    summa += i;
                }
            }

            if (summa == chislo)
            {
                Console.WriteLine(chislo);
            }
        }
    }
}