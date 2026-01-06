using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Числа от 300 до 600 с суммой делителей кратной 10:");

        for (int chislo = 300; chislo <= 600; chislo++)
        {
            int sum = 0;
            for (int del = 1; del <= chislo; del++)
            {
                if (chislo % del == 0)
                    sum += del;
            }
            if (sum % 10 == 0)
                Console.WriteLine(chislo);
        }
    }
}