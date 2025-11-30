using System;
class Program
{
    static void Main()
    {
        int[] chempionat1 = { 2, 1, 3, 0, 2, 4, 1, 2, 3, 1, 0, 2, 1, 3, 2, 1, 2, 0, 1, 3, 2, 1, 0, 2, 1, 3 };
        int[] chempionat2 = { 1, 2, 0, 3, 1, 2, 2, 1, 0, 2, 3, 1, 2, 0, 1, 2, 3, 1, 2, 0, 1, 2, 3, 1, 0, 2 };

        int vsego = 0;

        for (int i = 0; i < 26; i++)
        {
            vsego += chempionat1[i];
            vsego += chempionat2[i];
        }

        Console.WriteLine($"Всего забито мячей: {vsego}");
    }
}