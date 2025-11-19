using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 8, 25, 12, 5, 30, 18, 3, 22, 7 };

        int summa = 0;
        int count = 0;

        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] > 10)
            {
                summa += massiv[i];
                count++;
            }
        }

        if (count > 0)
        {
            double srednee = (double)summa / count;
            Console.WriteLine($"Среднее арифметическое элементов >10: {srednee}");
        }
        else
        {
            Console.WriteLine("Нет элементов больше 10");
        }
    }
}