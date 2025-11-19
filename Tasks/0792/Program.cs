using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 120, 45, 300, 78, 90, 123, 50, 67, 400, 25 };

        int count = 0;
        for (int i = 0; i < massiv.Length - 1; i++)
        {
            if (massiv[i] % 10 == 0 && massiv[i + 1] % 10 == 0)
            {
                count++;
            }
        }

        Console.WriteLine($"Пар соседних элементов оканчивающихся нулем: {count}");
    }
}