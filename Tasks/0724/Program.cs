using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        int[] massiv = new int[n];

        for (int i = 0; i < n; i++)
        {
            massiv[i] = 1;
            for (int j = 0; j <= i; j++)
            {
                massiv[i] *= 2;
            }
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"2^{i + 1} = {massiv[i]}");
        }
    }
}