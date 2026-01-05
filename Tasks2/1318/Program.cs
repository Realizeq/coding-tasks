using System;
class Program
{
    static void Main()
    {
        int[] a = new int[30];
        Console.WriteLine("Введите 30 целых чисел:");

        for (int i = 0; i < 30; i++)
        {
            Console.Write($"a[{i + 1}]: ");
            a[i] = int.Parse(Console.ReadLine());
        }

        int pervii = a[0];
        int count = 1;
        bool vseq = true;

        for (int i = 1; i < 30; i++)
        {
            if (vseq && a[i] == pervii)
            {
                count++;
            }
            else
            {
                vseq = false;
            }
        }

        Console.WriteLine($"Количество равных первому элементу в начале: {count}");
    }
}