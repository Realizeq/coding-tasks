using System;
class Program
{
    static void Main()
    {
        // а)
        Console.Write("Введите k: ");
        int k = int.Parse(Console.ReadLine());

        int num1 = 1;
        int den1 = 1;
        int num2 = 2;
        int den2 = 1;

        if (k == 1)
        {
            Console.WriteLine($"а) {num1}/{den1}");
        }
        else if (k == 2)
        {
            Console.WriteLine($"а) {num2}/{den2}");
        }
        else
        {
            for (int i = 3; i <= k; i++)
            {
                int numNext = num1 + num2;
                int denNext = den1 + den2;
                num1 = num2;
                den1 = den2;
                num2 = numNext;
                den2 = denNext;
            }
            Console.WriteLine($"а) {num2}/{den2}");
        }

        // б)
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("б) ");
        int numA = 1;
        int denA = 1;
        int numB = 2;
        int denB = 1;

        if (n >= 1) Console.Write($"{numA}/{denA} ");
        if (n >= 2) Console.Write($"{numB}/{denB} ");

        for (int i = 3; i <= n; i++)
        {
            int numNext = numA + numB;
            int denNext = denA + denB;
            Console.Write($"{numNext}/{denNext} ");
            numA = numB;
            denA = denB;
            numB = numNext;
            denB = denNext;
        }
    }
}