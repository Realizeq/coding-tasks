using System;
class Program
{
    static void Main()
    {
        int[] resultaty = { 125, 118, 132, 115, 128, 122, 135, 120, 130, 124, 138, 117, 129, 123, 136, 119, 131, 126, 139, 121, 133, 127, 140, 116, 134 };

        int min = resultaty[0];

        for (int i = 1; i < resultaty.Length; i++)
        {
            if (resultaty[i] < min)
            {
                min = resultaty[i];
            }
        }

        Console.WriteLine($"Результат победителя: {min}");
    }
}