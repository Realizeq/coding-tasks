using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 10, 20, 30, 25, 40, 50, 60, 55, 70, 80 };

        Console.WriteLine("Массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        int indexNarusheniya = -1;
        for (int i = 0; i < massiv.Length - 1; i++)
        {
            if (massiv[i] > massiv[i + 1])
            {
                indexNarusheniya = i + 1;
                break;
            }
        }

        if (indexNarusheniya == -1)
        {
            Console.WriteLine("Массив упорядочен по возрастанию");
        }
        else
        {
            Console.WriteLine($"Массив не упорядочен. Первое нарушение: {indexNarusheniya}");
        }
    }
}