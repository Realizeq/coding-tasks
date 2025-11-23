using System;
class Program
{
    static void Main()
    {
        int[] a = { 1250, 1180, 1320, 1150, 1280, 1220, 1350, 1200, 1300, 1240, 1380, 1170, 1290, 1230, 1360, 1190, 1310, 1260, 1390, 1210, 1330, 1270, 1340 };

        int[] sortirovanny = new int[a.Length];
        Array.Copy(a, sortirovanny, a.Length);
        Array.Sort(sortirovanny);
        int[] indeksy = new int[4];
        int count = 0;

        for (int i = 0; i < sortirovanny.Length && count < 4; i++)
        {
            for (int j = 0; j < a.Length && count < 4; j++)
            {
                if (a[j] == sortirovanny[i] && Array.IndexOf(indeksy, j) == -1)
                {
                    indeksy[count] = j;
                    count++;
                    break;
                }
            }
        }

        Array.Sort(indeksy);
        Console.WriteLine($"Позиции: {indeksy[0] + 1}, {indeksy[1] + 1}, {indeksy[2] + 1}, {indeksy[3] + 1}");
        Console.WriteLine($"Результаты: {a[indeksy[0]]}, {a[indeksy[1]]}, {a[indeksy[2]]}, {a[indeksy[3]]}");
        Console.WriteLine($"Сумма: {a[indeksy[0]] + a[indeksy[1]] + a[indeksy[2]] + a[indeksy[3]]}");
    }
}