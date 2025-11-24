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

        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Введите m: ");
        int m = int.Parse(Console.ReadLine());

        int countBolsheN = 0;
        int countMensheM = 0;

        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] > n)
            {
                countBolsheN++;
            }
            if (massiv[i] < m)
            {
                countMensheM++;
            }
        }

        int[] noviyMassiv = new int[massiv.Length + countBolsheN + countMensheM];
        int index = 0;

        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] > n)
            {
                noviyMassiv[index] = n;
                index++;
            }
            noviyMassiv[index] = massiv[i];
            index++;
            if (massiv[i] < m)
            {
                noviyMassiv[index] = m;
                index++;
            }
        }

        Console.WriteLine("После вставки:");
        for (int i = 0; i < noviyMassiv.Length; i++)
        {
            Console.WriteLine($"{noviyMassiv[i]}");
        }

        Console.WriteLine($"Максимальный размер исходного массива: {massiv.Length * 3}");
    }
}