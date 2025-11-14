using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Трехзначные простые числа:");

        for (int chislo = 100; chislo <= 999; chislo++)
        {
            bool prostoe = true;

            for (int i = 2; i < chislo; i++)
            {
                if (chislo % i == 0)
                {
                    prostoe = false;
                    break;
                }
            }

            if (prostoe)
            {
                Console.WriteLine(chislo);
            }
        }
    }
}