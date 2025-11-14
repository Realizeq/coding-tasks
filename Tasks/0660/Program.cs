using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Совершенные числа меньше 100000:");

        int chislo = 1;

        while (chislo < 100000)
        {
            int summa = 0;
            int i = 1;

            while (i < chislo)
            {
                if (chislo % i == 0)
                {
                    summa += i;
                }
                i++;
            }

            if (summa == chislo)
            {
                Console.WriteLine(chislo);
            }

            chislo++;
        }
    }
}