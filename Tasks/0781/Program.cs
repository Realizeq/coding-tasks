using System;
class Program
{
    static void Main()
    {
        int[] ocenki = { 5, 4, 3, 2, 5, 4, 3, 2, 5, 4, 3, 2, 5, 4, 3, 2, 5, 4, 3, 2, 5, 4, 3, 2, 5 };

        int count = 0;
        for (int i = 0; i < ocenki.Length; i++)
        {
            if (ocenki[i] == 2)
            {
                count++;
            }
        }

        Console.WriteLine($"Неуспевающих по химии: {count}");
    }
}