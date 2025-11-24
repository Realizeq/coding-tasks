using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, -25, 8, -30, 12, 35, -18, 40, -5, 22 };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        int indexOtr = -1;
        int indexPol = -1;

        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] < 0 && indexOtr == -1)
            {
                indexOtr = i;
            }
        }

        for (int i = massiv.Length - 1; i >= 0; i--)
        {
            if (massiv[i] > 0 && indexPol == -1)
            {
                indexPol = i;
            }
        }

        if (indexOtr != -1 && indexPol != -1)
        {
            int temp = massiv[indexOtr];
            massiv[indexOtr] = massiv[indexPol];
            massiv[indexPol] = temp;
        }

        Console.WriteLine("После замены:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }
    }
}