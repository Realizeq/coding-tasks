using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, -8, 32, -12, 45, -3, 0, 27, -20, 10 };

        int summaPolozhitelnyh = 0;
        int countPolozhitelnyh = 0;
        int summaOtritsatelnyh = 0;
        int countOtritsatelnyh = 0;

        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] > 0)
            {
                summaPolozhitelnyh += massiv[i];
                countPolozhitelnyh++;
            }
            else if (massiv[i] < 0)
            {
                summaOtritsatelnyh += massiv[i];
                countOtritsatelnyh++;
            }
        }

        if (countPolozhitelnyh > 0)
        {
            double sredneePolozhitelnyh = (double)summaPolozhitelnyh / countPolozhitelnyh;
            Console.WriteLine($"Среднее положительных: {sredneePolozhitelnyh}");
        }
        else
        {
            Console.WriteLine("Нет положительных элементов");
        }

        if (countOtritsatelnyh > 0)
        {
            double sredneeOtritsatelnyh = (double)summaOtritsatelnyh / countOtritsatelnyh;
            Console.WriteLine($"Среднее отрицательных: {sredneeOtritsatelnyh}");
        }
        else
        {
            Console.WriteLine("Нет отрицательных элементов");
        }
    }
}