using System;
class Program
{
    static int NOD(int a, int b)
    {
        while (b != 0)
        {
            int ost = a % b;
            a = b;
            b = ost;
        }
        return a;
    }

    static void Main()
    {
        Console.Write("Введите количество чисел: ");
        int n = int.Parse(Console.ReadLine());

        int[] chisla = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите число {i + 1}: ");
            chisla[i] = int.Parse(Console.ReadLine());
        }

        int tekNOD = chisla[0];
        for (int i = 1; i < n; i++)
        {
            tekNOD = NOD(tekNOD, chisla[i]);
        }

        Console.WriteLine($"Наибольший общий делитель: {tekNOD}");
    }
}