using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        int[] kupyuri = { 64, 32, 16, 8, 4, 2, 1 };

        for (int summa = n; summa <= n + 10; summa++)
        {
            Console.Write($"Сумма {summa}: ");
            int ost = summa;

            for (int i = 0; i < kupyuri.Length; i++)
            {
                int count = ost / kupyuri[i];
                if (count > 0)
                {
                    Console.Write($"{count} по {kupyuri[i]} ");
                    ost -= count * kupyuri[i];
                }
            }
            Console.WriteLine();
        }
    }
}