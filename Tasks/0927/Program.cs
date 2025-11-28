using System;
class Program
{
    static void Main()
    {
        float[] massiv = { 1.5f, 2.3f, 1.5f, 4.1f, 2.3f, 5.7f };

        int razlichnih = 0;

        for (int i = 0; i < massiv.Length; i++)
        {
            bool unikalnoe = true;

            for (int j = 0; j < i; j++)
            {
                if (massiv[i] == massiv[j])
                {
                    unikalnoe = false;
                    break;
                }
            }

            if (unikalnoe)
            {
                razlichnih++;
            }
        }

        Console.WriteLine($"Массив: {string.Join(", ", massiv)}");
        Console.WriteLine($"Количество различных элементов: {razlichnih}");
    }
}