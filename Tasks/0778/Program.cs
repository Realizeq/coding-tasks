using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, -8, 32, -12, 45, -3, 0, 27, -20, 10 };

        int count = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] >= 0)
            {
                count++;
            }
        }

        Console.WriteLine($"Количество неотрицательных элементов: {count}");
    }
}