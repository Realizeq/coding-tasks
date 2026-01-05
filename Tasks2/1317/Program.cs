using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите количество чисел: ");
        int n = int.Parse(Console.ReadLine());

        int count = 0;
        bool vseq = true;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите число {i + 1}: ");
            float chislo = float.Parse(Console.ReadLine());

            if (vseq && chislo < 0)
            {
                count++;
            }
            else
            {
                vseq = false;
            }
        }

        Console.WriteLine($"Количество первых подряд идущих отрицательных: {count}");
    }
}