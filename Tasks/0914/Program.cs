using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 100, 95, 90, 85, 80, 75, 70, 65, 60, 55 };

        Console.WriteLine("Массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());

        int index = 0;
        while (index < massiv.Length && massiv[index] >= a)
        {
            index++;
        }

        if (index < massiv.Length)
        {
            Console.WriteLine("Элементы после первого меньшего a:");
            for (int i = index; i < massiv.Length; i++)
            {
                Console.WriteLine($"{massiv[i]}");
            }

            Console.WriteLine("Элементы больше a:");
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine($"{massiv[i]}");
            }
        }
        else
        {
            Console.WriteLine($"Нет элементов меньше {a}");
        }
    }
}