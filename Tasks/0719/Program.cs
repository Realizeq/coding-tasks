using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

        Console.Write("Введите индекс: ");
        int index = int.Parse(Console.ReadLine());

        if (index >= 0 && index < massiv.Length)
        {
            Console.WriteLine($"[{index}] = {massiv[index]}");
        }
        else
        {
            Console.WriteLine("Неверный индекс");
        }
    }
}