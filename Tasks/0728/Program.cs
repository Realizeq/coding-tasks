using System;
class Program
{
    static void Main()
    {
        int[] massiv = new int[10];

        massiv[0] = 1;
        massiv[1] = 1;

        for (int i = 2; i < 10; i++)
        {
            massiv[i] = massiv[i - 1] + massiv[i - 2];
        }

        Console.Write("Первые 10 чисел Фибоначчи: ");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"[{i}] = {massiv[i]}");
        }
    }
}