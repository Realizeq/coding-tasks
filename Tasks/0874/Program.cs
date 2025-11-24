using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 24, 8, 30, 12, 35, 18, 40, 5, 22 };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        Console.WriteLine("а) Удалены четные на нечетных местах:");
        int count = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            if (!(i % 2 == 0 && massiv[i] % 2 == 0))
            {
                massiv[count] = massiv[i];
                count++;
            }
        }
        for (int i = count; i < massiv.Length; i++)
        {
            massiv[i] = 0;
        }
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        Console.WriteLine("б) Удалены кратные 3 или 5:");
        count = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] % 3 != 0 && massiv[i] % 5 != 0)
            {
                massiv[count] = massiv[i];
                count++;
            }
        }
        for (int i = count; i < massiv.Length; i++)
        {
            massiv[i] = 0;
        }
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }
    }
}