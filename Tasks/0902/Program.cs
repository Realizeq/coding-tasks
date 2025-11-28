using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

        Console.WriteLine("Массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("а) Элементы меньше a:");
        int i1 = 0;
        while (i1 < massiv.Length && massiv[i1] < a)
        {
            Console.WriteLine($"{massiv[i1]}");
            i1++;
        }

        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("б) Элементы вокруг n:");
        int i2 = 0;
        while (i2 < massiv.Length - 1 && !(massiv[i2] < n && massiv[i2 + 1] > n))
        {
            i2++;
        }
        Console.WriteLine($"Элемент слева: {massiv[i2]} (индекс {i2})");
        Console.WriteLine($"Элемент справа: {massiv[i2 + 1]} (индекс {i2 + 1})");

        Console.WriteLine("в) Ближайший к a:");
        int blizhayshii = massiv[0];
        int indexBlizhayshego = 0;
        int minRaznica = Math.Abs(massiv[0] - a);

        for (int i = 1; i < massiv.Length; i++)
        {
            int raznica = Math.Abs(massiv[i] - a);
            if (raznica < minRaznica)
            {
                minRaznica = raznica;
                blizhayshii = massiv[i];
                indexBlizhayshego = i;
            }
        }

        Console.WriteLine($"Ближайший: {blizhayshii} (индекс {indexBlizhayshego})");
    }
}