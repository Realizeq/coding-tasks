using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Числа от 200 до 500 с 6 делителями:");

        for (int chislo = 200; chislo <= 500; chislo++)
        {
            int deliteli = 0;

            for (int i = 1; i <= chislo; i++)
            {
                if (chislo % i == 0)
                {
                    deliteli++;
                }
            }

            if (deliteli == 6)
            {
                Console.WriteLine(chislo);
            }
        }
    }
}