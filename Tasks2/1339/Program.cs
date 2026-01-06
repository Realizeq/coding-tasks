using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        int b = int.Parse(Console.ReadLine());

        int maxDeliteley = 0;
        int chisloMax = 0;
        int chisloMin = 0;

        for (int chislo = a; chislo <= b; chislo++)
        {
            int count = 0;
            for (int del = 1; del <= chislo; del++)
            {
                if (chislo % del == 0)
                    count++;
            }

            if (count > maxDeliteley)
            {
                maxDeliteley = count;
                chisloMax = chislo;
                chisloMin = chislo;
            }
            else if (count == maxDeliteley)
            {
                if (chislo > chisloMax) chisloMax = chislo;
                if (chislo < chisloMin) chisloMin = chislo;
            }
        }

        Console.WriteLine($"Максимальное количество делителей: {maxDeliteley}");
        Console.WriteLine($"а) Максимальное число: {chisloMax}");
        Console.WriteLine($"б) Минимальное число: {chisloMin}");
    }
}