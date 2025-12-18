using System;
class Program
{
    static bool Chetnoe(int chislo)
    {
        return chislo % 2 == 0;
    }

    static void Main()
    {
        int[] a = new int[8];
        int[] b = new int[8];

        Console.WriteLine("Введите 8 чисел первой последовательности:");
        for (int i = 0; i < 8; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Введите 8 чисел второй последовательности:");
        for (int i = 0; i < 8; i++)
        {
            b[i] = int.Parse(Console.ReadLine());
        }

        int chetA = 0;
        int nechetB = 0;

        for (int i = 0; i < 8; i++)
        {
            if (Chetnoe(a[i])) chetA++;
            if (!Chetnoe(b[i])) nechetB++;
        }

        Console.WriteLine($"Четных в первой: {chetA}");
        Console.WriteLine($"Нечетных во второй: {nechetB}");
    }
}