using System;
class Program
{
    static void Main()
    {
        double[] massiv = { 15.5, 25.8, 8.2, 30.7, 12.4, 35.9, 18.6, 40.3, 5.1, 22.8 };

        double max = massiv[0];
        double min = massiv[0];

        for (int i = 1; i < massiv.Length; i++)
        {
            if (massiv[i] > max)
            {
                max = massiv[i];
            }
            if (massiv[i] < min)
            {
                min = massiv[i];
            }
        }

        if (max - min <= 25)
        {
            Console.WriteLine("максимальный превышает минимальный не более чем на 25");
        }
        else
        {
            Console.WriteLine("максимальный превышает минимальный более чем на 25");
        }

        if (min < max / 2)
        {
            Console.WriteLine("минимальный меньше максимального более чем в 2 раза");
        }
        else
        {
            Console.WriteLine("минимальный не меньше максимального более чем в 2 раза");
        }
    }
}