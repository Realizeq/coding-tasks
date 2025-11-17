using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 120, 45, 300, 78, 90, 123, 50, 67, 400, 25 };

        Console.WriteLine("Номера элементов, оканчивающихся на 0:");
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] % 10 == 0)
            {
                Console.WriteLine($"Индекс: {i}, значение: {massiv[i]}");
            }
        }
    }
}