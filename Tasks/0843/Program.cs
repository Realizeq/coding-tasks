using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 25, 8, 30, 12, 35, 18, 40, 5, 22 };

        int max = massiv[0];
        int min = massiv[0];
        int indexMax = 0;
        int indexMin = 0;

        for (int i = 1; i < massiv.Length; i++)
        {
            if (massiv[i] > max)
            {
                max = massiv[i];
                indexMax = i;
            }
            if (massiv[i] < min)
            {
                min = massiv[i];
                indexMin = i;
            }
        }

        if (indexMin < indexMax)
        {
            Console.WriteLine("Раньше встретилось минимальное число");
        }
        else if (indexMax < indexMin)
        {
            Console.WriteLine("Раньше встретилось максимальное число");
        }
        else
        {
            Console.WriteLine("Максимальное и минимальное число - один элемент");
        }
    }
}