using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите количество чисел: ");
        int n = int.Parse(Console.ReadLine());

        float sum = 0;
        bool vseq = true;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите число {i + 1}: ");
            float chislo = float.Parse(Console.ReadLine());

            if (vseq && chislo % 2 != 0)
            {
                sum += chislo;
            }
            else
            {
                vseq = false;
            }
        }

        Console.WriteLine($"Сумма первых подряд идущих нечетных: {sum}");
    }
}