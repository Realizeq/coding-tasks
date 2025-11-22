using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 25, 8, 30, 12, 35, 18, 40, 5, 22, 25, 17, 30, 11, 26 };

        int countOdinakovyh = 0;

        for (int i = 0; i < massiv.Length; i++)
        {
            for (int j = i + 1; j < massiv.Length; j++)
            {
                if (massiv[i] == massiv[j])
                {
                    countOdinakovyh++;
                }
            }
        }

        if (countOdinakovyh == 2)
        {
            Console.WriteLine("В массиве ровно два одинаковых элемента");
        }
        else
        {
            Console.WriteLine("В массиве не ровно два одинаковых элемента");
        }
    }
}