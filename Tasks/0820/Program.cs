using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 2, 5, 5, 5, 8, 10, 10, 15, 15, 15, 15, 20, 22, 22, 25, 25, 25, 30, 35, 35, 40, 40, 45, 50, 50, 55, 60, 65, 70, 75 };

        int razlichnye = 1;

        for (int i = 0; i < massiv.Length - 1; i++)
        {
            if (massiv[i] != massiv[i + 1])
            {
                razlichnye++;
            }
        }

        Console.WriteLine($"Различных чисел: {razlichnye}");
    }
}