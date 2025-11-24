using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 25, 8, 30, 12, 35, 18, 40, 5, 22 };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        Console.WriteLine("а) Поменяны второй и пятый:");
        int temp = massiv[1];
        massiv[1] = massiv[4];
        massiv[4] = temp;
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        Console.WriteLine("б) Поменяны m-й и n-й:");
        Console.Write("Введите m: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());
        temp = massiv[m];
        massiv[m] = massiv[n];
        massiv[n] = temp;
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        Console.WriteLine("в) Поменяны третий и первый максимальный:");
        int max = massiv[0];
        int indexMax = 0;
        for (int i = 1; i < massiv.Length; i++)
        {
            if (massiv[i] > max)
            {
                max = massiv[i];
                indexMax = i;
            }
        }
        temp = massiv[2];
        massiv[2] = massiv[indexMax];
        massiv[indexMax] = temp;
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        Console.WriteLine("г) Поменяны первый и последний минимальный:");
        int min = massiv[0];
        int indexMin = 0;
        for (int i = 1; i < massiv.Length; i++)
        {
            if (massiv[i] <= min)
            {
                min = massiv[i];
                indexMin = i;
            }
        }
        temp = massiv[0];
        massiv[0] = massiv[indexMin];
        massiv[indexMin] = temp;
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }
    }
}