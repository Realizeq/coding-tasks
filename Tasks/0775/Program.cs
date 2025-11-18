using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 25, 8, 30, 12, 35, 18, 40, 5, 22 };

        int summaBolshe20 = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] > 20)
            {
                summaBolshe20 += massiv[i];
            }
        }

        if (summaBolshe20 > 100)
        {
            Console.WriteLine("Верно, сумма элементов >20 превышает 100");
        }
        else
        {
            Console.WriteLine("Неверно, сумма элементов >20 не превышает 100");
        }

        int summaMenshe50 = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] < 50)
            {
                summaMenshe50 += massiv[i];
            }
        }

        if (summaMenshe50 % 2 == 0)
        {
            Console.WriteLine("Верно, сумма элементов <50 четная");
        }
        else
        {
            Console.WriteLine("Неверно, сумма элементов <50 нечетная");
        }
    }
}