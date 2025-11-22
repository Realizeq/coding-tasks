using System;
class Program
{
    static void Main()
    {
        int[] massa = { 85, 120, 95, 110, 130, 75, 100, 90, 115, 105, 125, 80, 140, 70, 150, 65, 135, 85, 145, 60, 155, 95, 160, 55, 165 };

        int summaPolnyh = 0;
        int countPolnyh = 0;
        int summaOstalnyh = 0;
        int countOstalnyh = 0;

        for (int i = 0; i < massa.Length; i++)
        {
            if (massa[i] > 100)
            {
                summaPolnyh += massa[i];
                countPolnyh++;
            }
            else
            {
                summaOstalnyh += massa[i];
                countOstalnyh++;
            }
        }

        if (countPolnyh > 0)
        {
            double sredneePolnyh = (double)summaPolnyh / countPolnyh;
            Console.WriteLine($"Средняя масса полных: {sredneePolnyh}");
        }

        if (countOstalnyh > 0)
        {
            double sredneeOstalnyh = (double)summaOstalnyh / countOstalnyh;
            Console.WriteLine($"Средняя масса остальных: {sredneeOstalnyh}");
        }
    }
}