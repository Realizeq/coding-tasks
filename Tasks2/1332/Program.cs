using System;

class Program
{
    static void Main()
    {
        float chisl1 = 1, znam1 = 1;
        float chisl2 = 2, znam2 = 1;
        float drob1 = chisl1 / znam1;
        float drob2 = chisl2 / znam2;

        while (Math.Abs(drob2 - drob1) > 0.001f)
        {
            float chisl3 = chisl1 + chisl2;
            float znam3 = znam1 + znam2;
            float drob3 = chisl3 / znam3;

            chisl1 = chisl2;
            znam1 = znam2;
            drob1 = drob2;

            chisl2 = chisl3;
            znam2 = znam3;
            drob2 = drob3;
        }

        Console.WriteLine($"Первый член, отличающийся не более чем на 0.001: {drob2}");
    }
}