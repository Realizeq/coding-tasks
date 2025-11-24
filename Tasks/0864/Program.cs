using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        Console.WriteLine("а) Между 2-м и 10-м элементами:");
        int start = 2;
        int end = 9;
        for (int i = 0; i < (end - start + 1) / 2; i++)
        {
            int temp = massiv[start + i];
            massiv[start + i] = massiv[end - i];
            massiv[end - i] = temp;
        }
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        Console.WriteLine("б) Между k-м и s-м элементами:");
        Console.Write("Введите k: ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Введите s: ");
        int s = int.Parse(Console.ReadLine());
        start = k;
        end = s - 2;
        for (int i = 0; i < (end - start + 1) / 2; i++)
        {
            int temp = massiv[start + i];
            massiv[start + i] = massiv[end - i];
            massiv[end - i] = temp;
        }
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        Console.WriteLine("в) Между максимальным и минимальным:");
        int maxIndex = 0;
        int minIndex = 0;
        for (int i = 1; i < massiv.Length; i++)
        {
            if (massiv[i] > massiv[maxIndex])
                maxIndex = i;
            if (massiv[i] < massiv[minIndex])
                minIndex = i;
        }
        start = Math.Min(maxIndex, minIndex);
        end = Math.Max(maxIndex, minIndex);
        for (int i = 0; i < (end - start + 1) / 2; i++)
        {
            int temp = massiv[start + i];
            massiv[start + i] = massiv[end - i];
            massiv[end - i] = temp;
        }
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }
    }
}