using System;
class Program
{
    static void Main()
    {
        for (int chislo = 120; chislo <= 140; chislo++)
        {
            int deliteli = 0;

            for (int i = 1; i <= chislo; i++)
            {
                if (chislo % i == 0)
                {
                    deliteli++;
                }
            }

            Console.WriteLine($"Число {chislo}: {deliteli} делителей");
        }
    }
}