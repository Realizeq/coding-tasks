using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 25, 8, 30, 12, 35, 18, 40, 5, 22 };

        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        int b = int.Parse(Console.ReadLine());

        int count = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] >= a && massiv[i] <= b)
            {
                count++;
            }
        }

        Console.WriteLine($"Элементов от {a} до {b}: {count}");
    }
}