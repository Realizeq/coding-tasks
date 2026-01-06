using System;
class Program
{
    static void Main()
    {
        for (int chislo = 50; chislo <= 70; chislo++)
        {
            int sum = 0;
            for (int del = 1; del <= chislo; del++)
            {
                if (chislo % del == 0)
                    sum += del;
            }
            Console.WriteLine($"Число {chislo}: сумма делителей = {sum}");
        }
    }
}