using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 2, 5, 5, 5, 8, 10, 10, 15, 15, 15, 15, 20, 22, 22, 25, 25, 25, 30, 35, 35 };

        int odinakovyePodryad = 0;
        int razlichnye = 1;

        for (int i = 0; i < massiv.Length - 1; i++)
        {
            if (massiv[i] == massiv[i + 1])
            {
                odinakovyePodryad++;
            }
            else
            {
                razlichnye++;
            }
        }

        Console.WriteLine($"Одинаковых подряд: {odinakovyePodryad}");
        Console.WriteLine($"Различных чисел: {razlichnye}");
    }
}