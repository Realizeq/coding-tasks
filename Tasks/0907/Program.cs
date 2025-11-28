using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 25, 8, 30, 12, 35, 18, 40, 5, 22, 17, 27 };

        Console.WriteLine("Массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        Console.WriteLine("а) Элементы до первого n:");
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        int indexN = 0;
        while (indexN < massiv.Length && massiv[indexN] != n)
        {
            Console.WriteLine($"{massiv[indexN]}");
            indexN++;
        }

        Console.WriteLine("б) Элементы после последнего оканчивающегося на 7:");
        int index7 = massiv.Length - 1;
        while (index7 >= 0 && massiv[index7] % 10 != 7)
        {
            index7--;
        }

        if (index7 >= 0)
        {
            for (int i = index7 + 1; i < massiv.Length; i++)
            {
                Console.WriteLine($"{massiv[i]}");
            }
        }
    }
}