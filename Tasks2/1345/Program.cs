using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        int b = int.Parse(Console.ReadLine());

        int maxSum = 0;
        int chisloMax = a;

        for (int chislo = a; chislo <= b; chislo++)
        {
            int sum = 0;
            for (int del = 1; del <= chislo; del++)
            {
                if (chislo % del == 0)
                    sum += del;
            }

            if (sum > maxSum)
            {
                maxSum = sum;
                chisloMax = chislo;
            }
        }

        Console.WriteLine($"Число с максимальной суммой делителей: {chisloMax}");
        Console.WriteLine($"Сумма делителей: {maxSum}");
    }
}