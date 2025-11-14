using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Числа от 300 до 600 с суммой делителей кратной 10:");

        for (int chislo = 300; chislo <= 600; chislo++)
        {
            int summa = 0;

            for (int i = 1; i <= chislo; i++)
            {
                if (chislo % i == 0)
                {
                    summa += i;
                }
            }

            if (summa % 10 == 0)
            {
                Console.WriteLine(chislo);
            }
        }
    }
}