using System;
class Program
{
    static void Main()
    {
        float[] naselenie = { 144, 8, 67, 146, 38, 83, 10, 126, 11, 46, 9, 17, 5, 12, 35, 61, 25, 14, 7, 19, 22, 6, 4, 16, 13, 8, 11, 9 };
        float[] ploshad = { 17150, 9980, 9985, 3287, 3779, 9520, 8515, 9640, 3013, 5515, 4503, 5131, 2380, 2736, 3370, 6522, 2364, 1852, 1995, 2149, 1762, 1031, 923, 1124, 1319, 866, 1141, 997 };

        float A = 5000;
        float vsegoNas = 0;

        for (int i = 0; i < 28; i++)
        {
            if (ploshad[i] <= A)
            {
                vsegoNas += naselenie[i];
            }
        }

        Console.WriteLine($"Общая численность государств с площадью до {A} тыс.кв.км: {vsegoNas} млн человек");
    }
}