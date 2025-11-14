using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Числа от 1 до 300 с 5 делителями:");

        for (int chislo = 1; chislo <= 300; chislo++)
        {
            int deliteli = 0;

            for (int i = 1; i <= chislo; i++)
            {
                if (chislo % i == 0)
                {
                    deliteli++;
                }
            }

            if (deliteli == 5)
            {
                Console.WriteLine(chislo);
            }
        }
    }
}