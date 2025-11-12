using System;
class Program
{
    static void Main()
    {
        float a = 2.0f;
        float x = 3.0f;
        float e = 0.001f;

        Console.WriteLine($"a = {a}, x = {x}, e = {e}");
        Console.WriteLine("Поиск первого члена с разницей квадратов < e:");

        float yPred = a;
        float yTek = 0.5f * (yPred + x / (yPred - 1.0f));
        int n = 2;
        bool found = false;

        while (!found)
        {
            float raznica = Math.Abs(yTek * yTek - yPred * yPred);

            if (raznica < e)
            {
                Console.WriteLine($"Член {n}: y = {yTek}, разница квадратов = {raznica}");
                found = true;
            }

            yPred = yTek;
            yTek = 0.5f * (yPred + x / (yPred - 1.0f));
            n++;
        }

        yPred = a;
        yTek = 0.5f * (yPred + x / (yPred - 1.0f));

        for (int i = 2; i <= 100; i++)
        {
            float raznica = Math.Abs(yTek * yTek - yPred * yPred);

            if (raznica < e)
            {
                Console.WriteLine($"Член {i}: y = {yTek}, разница квадратов = {raznica}");
                break;
            }

            yPred = yTek;
            yTek = 0.5f * (yPred + x / (yPred - 1.0f));
        }
    }
}