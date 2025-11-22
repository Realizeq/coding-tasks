using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 25, 8, 30, 12, 35, 18, 40, 5, 22, 17, 11, 26, 25, 19 };

        int odinakovyiElement = 0;
        int index1 = -1;
        int index2 = -1;

        for (int i = 0; i < massiv.Length; i++)
        {
            for (int j = i + 1; j < massiv.Length; j++)
            {
                if (massiv[i] == massiv[j])
                {
                    odinakovyiElement = massiv[i];
                    index1 = i;
                    index2 = j;
                    break;
                }
            }
            if (index1 != -1) break;
        }

        if (index1 != -1)
        {
            Console.WriteLine($"Одинаковые элементы: {odinakovyiElement}");
            Console.WriteLine($"Позиции: {index1} и {index2}");
        }
        else
        {
            Console.WriteLine("Одинаковых элементов нет");
        }
    }
}