using System;
class Program
{
    static void Main()
    {
        for (int chislo = 50; chislo <= 70; chislo++)
        {
            int summa = 0;

            for (int i = 1; i <= chislo; i++)
            {
                if (chislo % i == 0)
                {
                    summa += i;
                }
            }

            Console.WriteLine($"Число {chislo}: сумма делителей = {summa}");
        }
    }
}