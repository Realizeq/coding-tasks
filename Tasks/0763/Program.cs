using System;
class Program
{
    static void Main()
    {
        int[] ucheniki = { 25, 28, 30, 24, 26, 29, 27, 23, 25, 28, 30, 24, 26, 29, 27, 23, 25, 28, 30, 24, 26, 29, 27, 23, 25, 28, 30, 24, 26, 29, 27, 23, 25, 28, 30, 24, 26, 29, 27, 23, 25, 28 };

        int summa = 0;
        for (int i = 0; i < ucheniki.Length; i++)
        {
            summa += ucheniki[i];
        }

        if (summa >= 1000 && summa <= 9999)
        {
            Console.WriteLine("Верно, общее число учеников четырехзначное");
        }
        else
        {
            Console.WriteLine("Неверно, общее число учеников не четырехзначное");
        }
    }
}