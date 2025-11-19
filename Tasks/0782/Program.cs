using System;
class Program
{
    static void Main()
    {
        int[] stoimost = { 45000, 38000, 52000 };

        Console.Write("Введите s: ");
        int s = int.Parse(Console.ReadLine());

        int count = 0;
        for (int i = 0; i < stoimost.Length; i++)
        {
            if (stoimost[i] > s)
            {
                count++;
            }
        }

        Console.WriteLine($"Дней с продажами > {s}: {count}");
    }
}