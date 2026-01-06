using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Числа от 200 до 500 с 6 делителями:");

        for (int chislo = 200; chislo <= 500; chislo++)
        {
            int count = 0;
            for (int del = 1; del <= chislo; del++)
            {
                if (chislo % del == 0)
                    count++;
            }
            if (count == 6)
                Console.WriteLine(chislo);
        }
    }
}