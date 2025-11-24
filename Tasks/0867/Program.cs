using System;
class Program
{
    static void Main()
    {
        int[] stoimost = { 150, 230, 75, 420, 180, 95, 310, 125, 280, 65, 390, 110, 340, 200, 450, 80, 260, 170, 380, 90 };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < stoimost.Length; i++)
        {
            Console.WriteLine($"{stoimost[i]}");
        }

        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = n; i < stoimost.Length - 1; i++)
        {
            stoimost[i] = stoimost[i + 1];
        }
        stoimost[stoimost.Length - 1] = 0;

        Console.WriteLine("После удаления товара:");
        for (int i = 0; i < stoimost.Length; i++)
        {
            Console.WriteLine($"{stoimost[i]}");
        }
    }
}