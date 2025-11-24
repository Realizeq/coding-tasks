using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 25, 8, 30, 15, 35, 8, 40, 25, 22, 30, 15, 8, 45, 25 };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        int count = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            bool povtoryaetsya = false;
            for (int j = 0; j < count; j++)
            {
                if (massiv[i] == massiv[j])
                {
                    povtoryaetsya = true;
                    break;
                }
            }
            if (!povtoryaetsya)
            {
                massiv[count] = massiv[i];
                count++;
            }
        }

        for (int i = count; i < massiv.Length; i++)
        {
            massiv[i] = 0;
        }

        Console.WriteLine("После удаления повторяющихся:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }
    }
}