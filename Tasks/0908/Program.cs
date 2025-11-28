using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 24, 8, 30, 12, 35, 18, 40, 5, 22 };

        Console.WriteLine("Массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        int indexNechet = -1;
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] % 2 != 0)
            {
                indexNechet = i;
                break;
            }
        }

        if (indexNechet != -1)
        {
            Console.WriteLine($"а) Первый нечетный: {indexNechet}");
        }
        else
        {
            Console.WriteLine("а) Нечетных элементов нет");
        }

        int indexKrat13 = -1;
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] % 13 == 0)
            {
                indexKrat13 = i;
                break;
            }
        }

        if (indexKrat13 != -1)
        {
            Console.WriteLine($"б) Первый кратный 13: {indexKrat13}");
        }
        else
        {
            Console.WriteLine("б) Элементов кратных 13 нет");
        }
    }
}