using System;
class Program
{
    static void Main()
    {
        int[] massiv = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Введите элемент {i}: ");
            massiv[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"[{i}] = {massiv[i]}");
        }
    }
}