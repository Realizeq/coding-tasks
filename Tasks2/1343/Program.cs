using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Числа от 100 до 300 с суммой делителей 50:");

        for (int chislo = 100; chislo <= 300; chislo++)
        {
            int sum = 0;
            for (int del = 1; del <= chislo; del++)
            {
                if (chislo % del == 0)
                    sum += del;
            }
            if (sum == 50)
                Console.WriteLine(chislo);
        }
    }
}