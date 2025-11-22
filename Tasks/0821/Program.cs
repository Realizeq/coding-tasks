using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 7, 24, 9, 11, 13, 30, 17, 19, 21, 8, 23, 25, 27, 40, 31, 33, 12, 35, 37 };

        int maxDlina = 0;
        int tekushayaDlina = 0;

        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] % 2 != 0)
            {
                tekushayaDlina++;
                if (tekushayaDlina > maxDlina)
                {
                    maxDlina = tekushayaDlina;
                }
            }
            else
            {
                tekushayaDlina = 0;
            }
        }

        Console.WriteLine($"Наибольшая длина отрезка нечетных чисел: {maxDlina}");
    }
}