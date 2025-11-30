using System;
class Program
{
    static void Main()
    {
        float[] naselenie = { 144, 8, 67, 146, 38, 83, 10, 126, 11, 46, 9, 17, 5, 12, 35, 61, 25, 14, 7, 19, 22, 6, 4, 16, 13, 8, 11, 9 };
        float[] ploshad = { 17, 9, 10, 10, 9, 9, 8, 9, 8, 6, 5, 5, 4, 4, 3, 3, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1 };

        float vsegoNas = 0;

        for (int i = 0; i < 28; i++)
        {
            if (ploshad[i] > 5)
            {
                vsegoNas += naselenie[i];
            }
        }

        Console.WriteLine($"Общая численность государств с площадью >5 млн кв.км: {vsegoNas} млн человек");
    }
}