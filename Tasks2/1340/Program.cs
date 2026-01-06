using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Трехзначные простые числа:");

        for (int chislo = 100; chislo <= 999; chislo++)
        {
            bool prostoe = true;
            for (int del = 2; del <= Math.Sqrt(chislo); del++)
            {
                if (chislo % del == 0)
                {
                    prostoe = false;
                    break;
                }
            }
            if (prostoe)
                Console.WriteLine(chislo);
        }
    }
}