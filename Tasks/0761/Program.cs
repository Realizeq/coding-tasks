using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 12, -5, 8, -3, 15, -10, 7, -2, 9, -1 };

        int summa = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            summa += massiv[i];
        }

        if (summa >= 0)
        {
            Console.WriteLine("Верно, сумма неотрицательная");
        }
        else
        {
            Console.WriteLine("Неверно, сумма отрицательная");
        }
    }
}