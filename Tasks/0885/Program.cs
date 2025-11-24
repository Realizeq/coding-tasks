using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, -25, -8, 30, 12, -35, -18, 40, -5, 22 };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        Console.Write("Введите число n: ");
        int n = int.Parse(Console.ReadLine());

        int countVstavok = 0;
        for (int i = 0; i < massiv.Length - 1; i++)
        {
            if ((massiv[i] > 0 && massiv[i + 1] > 0) ||
                (massiv[i] < 0 && massiv[i + 1] < 0))
            {
                countVstavok++;
            }
        }

        int[] noviyMassiv = new int[massiv.Length + countVstavok];
        int index = 0;

        for (int i = 0; i < massiv.Length; i++)
        {
            noviyMassiv[index] = massiv[i];
            index++;

            if (i < massiv.Length - 1 &&
                ((massiv[i] > 0 && massiv[i + 1] > 0) ||
                 (massiv[i] < 0 && massiv[i + 1] < 0)))
            {
                noviyMassiv[index] = n;
                index++;
            }
        }

        Console.WriteLine("После вставки:");
        for (int i = 0; i < noviyMassiv.Length; i++)
        {
            Console.WriteLine($"{noviyMassiv[i]}");
        }

        Console.WriteLine($"Максимальный размер исходного массива: {massiv.Length * 2 - 1}");
    }
}