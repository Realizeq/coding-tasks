using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите m: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Числа меньше {n} с квадратом суммы цифр равным {m}:");

        for (int i = 1; i < n; i++)
        {
            int summa = 0;
            int chislo = i;

            while (chislo > 0)
            {
                summa += chislo % 10;
                chislo /= 10;
            }

            if (summa * summa == m)
            {
                Console.WriteLine(i);
            }
        }
    }
}