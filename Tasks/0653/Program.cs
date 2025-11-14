using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        int b = int.Parse(Console.ReadLine());

        int maxDeliteli = 0;
        int chisloMax = a;
        int chisloMin = a;

        for (int chislo = a; chislo <= b; chislo++)
        {
            int deliteli = 0;

            for (int i = 1; i <= chislo; i++)
            {
                if (chislo % i == 0)
                {
                    deliteli++;
                }
            }

            if (deliteli > maxDeliteli)
            {
                maxDeliteli = deliteli;
                chisloMax = chislo;
                chisloMin = chislo;
            }
            else if (deliteli == maxDeliteli)
            {
                if (chislo > chisloMax)
                {
                    chisloMax = chislo;
                }
                if (chislo < chisloMin)
                {
                    chisloMin = chislo;
                }
            }
        }

        Console.WriteLine($"Максимальное количество делителей: {maxDeliteli}");
        Console.WriteLine($"Максимальное число: {chisloMax}");
        Console.WriteLine($"Минимальное число: {chisloMin}");
    }
}