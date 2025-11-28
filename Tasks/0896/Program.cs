using System;
class Program
{
    static void Main()
    {
        int[] m = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < m.Length; i++)
        {
            Console.WriteLine($"{m[i]}");
        }

        int[] noviyMassiv = new int[m.Length];
        int index = 0;

        for (int i = 0; i < m.Length / 2; i++)
        {
            noviyMassiv[index] = m[i];
            index++;
            noviyMassiv[index] = m[m.Length - 1 - i];
            index++;
        }

        Console.WriteLine("После перестановки:");
        for (int i = 0; i < noviyMassiv.Length; i++)
        {
            Console.WriteLine($"{noviyMassiv[i]}");
        }
    }
}