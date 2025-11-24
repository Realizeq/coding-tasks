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

        Console.WriteLine("а) Вставлено число после первого отрицательного:");
        Console.Write("Введите число: ");
        int chislo = int.Parse(Console.ReadLine());

        int indexOtr = -1;
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] < 0)
            {
                indexOtr = i;
                break;
            }
        }

        if (indexOtr != -1)
        {
            int[] noviyMassiv = new int[massiv.Length + 1];
            for (int i = 0; i <= indexOtr; i++)
            {
                noviyMassiv[i] = massiv[i];
            }
            noviyMassiv[indexOtr + 1] = chislo;
            for (int i = indexOtr + 1; i < massiv.Length; i++)
            {
                noviyMassiv[i + 1] = massiv[i];
            }
            for (int i = 0; i < noviyMassiv.Length; i++)
            {
                Console.WriteLine($"{noviyMassiv[i]}");
            }
        }

        Console.WriteLine("б) Вставлено число перед последним четным:");
        Console.Write("Введите число: ");
        chislo = int.Parse(Console.ReadLine());

        int indexChet = -1;
        for (int i = massiv.Length - 1; i >= 0; i--)
        {
            if (massiv[i] % 2 == 0)
            {
                indexChet = i;
                break;
            }
        }

        if (indexChet != -1)
        {
            int[] noviyMassiv = new int[massiv.Length + 1];
            for (int i = 0; i < indexChet; i++)
            {
                noviyMassiv[i] = massiv[i];
            }
            noviyMassiv[indexChet] = chislo;
            for (int i = indexChet; i < massiv.Length; i++)
            {
                noviyMassiv[i + 1] = massiv[i];
            }
            for (int i = 0; i < noviyMassiv.Length; i++)
            {
                Console.WriteLine($"{noviyMassiv[i]}");
            }
        }
    }
}