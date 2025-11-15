using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("1) Простые множители по одному разу: ");
        int temp = n;
        for (int i = 2; i <= temp; i++)
        {
            if (temp % i == 0)
            {
                Console.Write(i + " ");
                while (temp % i == 0)
                {
                    temp /= i;
                }
            }
        }
        Console.Write("2) Простые множители с кратностью: ");
        temp = n;
        for (int i = 2; i <= temp; i++)
        {
            while (temp % i == 0)
            {
                Console.Write(i + " ");
                temp /= i;
            }
        }
    }
}