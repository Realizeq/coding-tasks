using System;
class Program
{
    static void Main()
    {
        for (int chislo = 120; chislo <= 140; chislo++)
        {
            int count = 0;
            for (int del = 1; del <= chislo; del++)
            {
                if (chislo % del == 0)
                    count++;
            }
            Console.WriteLine($"Число {chislo}: {count} делителей");
        }
    }
}