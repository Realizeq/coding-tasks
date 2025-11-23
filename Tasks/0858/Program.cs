using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 25, 8, 30, 12, 35, 18, 40, 5, 22 };

        for (int i = 0; i < massiv.Length - 1; i++)
        {
            if (massiv[i + 1] < massiv[i])
            {
                int temp = massiv[i];
                massiv[i] = massiv[i + 1];
                massiv[i + 1] = temp;
            }
        }

        Console.WriteLine($"Последний элемент: {massiv[massiv.Length - 1]}");
    }
}