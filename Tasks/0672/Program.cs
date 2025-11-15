using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите число 1: ");
        int nod = int.Parse(Console.ReadLine());

        for (int i = 2; i <= n; i++)
        {
            Console.Write($"Введите число {i}: ");
            int chislo = int.Parse(Console.ReadLine());

            int a = nod;
            int b = chislo;

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            nod = a;
        }

        Console.WriteLine($"НОД: {nod}");
    }
}