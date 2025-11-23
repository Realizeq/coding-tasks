using System;
class Program
{
    static void Main()
    {
        int[] ucheniki = { 25, 28, 30, 24, 26, 29, 27, 23, 25, 28, 30, 24 };

        int max = ucheniki[0];
        int min = ucheniki[0];

        for (int i = 1; i < ucheniki.Length; i++)
        {
            if (ucheniki[i] > max)
            {
                max = ucheniki[i];
            }
            if (ucheniki[i] < min)
            {
                min = ucheniki[i];
            }
        }

        if (max == min + 10)
        {
            Console.WriteLine("в самом многочисленном классе на 10 учеников больше");
        }
        else
        {
            Console.WriteLine("в самом многочисленном классе не на 10 учеников больше");
        }
    }
}