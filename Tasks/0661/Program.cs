using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        int b = int.Parse(Console.ReadLine());

        int maxSumma = 0;
        int chisloMax = a;

        for (int chislo = a; chislo <= b; chislo++)
        {
            int summa = 0;

            for (int i = 1; i <= chislo; i++)
            {
                if (chislo % i == 0)
                {
                    summa += i;
                }
            }

            if (summa > maxSumma)
            {
                maxSumma = summa;
                chisloMax = chislo;
            }
        }

        Console.WriteLine($"Число с максимальной суммой делителей: {chisloMax}");
        Console.WriteLine($"Сумма делителей: {maxSumma}");
    }
}