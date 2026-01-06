using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Числа от 1 до 300 с 5 делителями:");

        for (int chislo = 1; chislo <= 300; chislo++)
        {
            int count = 0;
            for (int del = 1; del <= chislo; del++)
            {
                if (chislo % del == 0)
                    count++;
            }
            if (count == 5)
                Console.WriteLine(chislo);
        }
    }
}