using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 24, 8, 30, 12, 35, -18, 40, -5, 22 };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        Console.WriteLine("а) Вставлено перед элементами, кратными a:");
        Console.Write("Введите число для вставки: ");
        int chislo = int.Parse(Console.ReadLine());
        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());

        int countKratnyh = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] % a == 0)
            {
                countKratnyh++;
            }
        }

        int[] noviyMassiv = new int[massiv.Length + countKratnyh];
        int index = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] % a == 0)
            {
                noviyMassiv[index] = chislo;
                index++;
            }
            noviyMassiv[index] = massiv[i];
            index++;
        }
        for (int i = 0; i < noviyMassiv.Length; i++)
        {
            Console.WriteLine($"{noviyMassiv[i]}");
        }

        Console.WriteLine("б) Вставлено после отрицательных элементов:");
        Console.Write("Введите число для вставки: ");
        chislo = int.Parse(Console.ReadLine());

        int countOtr = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] < 0)
            {
                countOtr++;
            }
        }

        noviyMassiv = new int[massiv.Length + countOtr];
        index = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            noviyMassiv[index] = massiv[i];
            index++;
            if (massiv[i] < 0)
            {
                noviyMassiv[index] = chislo;
                index++;
            }
        }
        for (int i = 0; i < noviyMassiv.Length; i++)
        {
            Console.WriteLine($"{noviyMassiv[i]}");
        }

        Console.WriteLine($"Максимальный размер массива в случае а): {massiv.Length * 2}");
        Console.WriteLine($"Максимальный размер массива в случае б): {massiv.Length * 2}");
    }
}