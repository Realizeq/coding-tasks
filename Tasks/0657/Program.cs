using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Числа от 100 до 300 с суммой делителей 50:");

        for (int chislo = 100; chislo <= 300; chislo++)
        {
            int summa = 0;

            for (int i = 1; i <= chislo; i++)
            {
                if (chislo % i == 0)
                {
                    summa += i;
                }
            }

            if (summa == 50)
            {
                Console.WriteLine(chislo);
            }
        }
    }
}