using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int chislo = int.Parse(Console.ReadLine());

        int koren = chislo;

        while (koren >= 10)
        {
            int summa = 0;
            int temp = koren;

            while (temp > 0)
            {
                summa += temp % 10;
                temp /= 10;
            }

            koren = summa;
        }

        Console.WriteLine($"Цифровой корень: {koren}");
    }
}