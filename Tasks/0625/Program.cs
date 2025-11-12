using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Поиск члена последовательности с разницей <= 0.001:");

        float chisl1 = 1.0f;
        float znam1 = 1.0f;
        float chisl2 = 2.0f;
        float znam2 = 1.0f;

        float pred = chisl1 / znam1;
        float tek = chisl2 / znam2;

        int n = 3;
        bool found = false;

        while (!found)
        {
            float raznica = Math.Abs(tek - pred);

            if (raznica <= 0.001f)
            {
                Console.WriteLine($"Член {n}: {tek}, разница: {raznica}");
                found = true;
            }

            float noviyChisl = chisl1 + chisl2;
            float noviyZnam = znam1 + znam2;

            chisl1 = chisl2;
            znam1 = znam2;
            chisl2 = noviyChisl;
            znam2 = noviyZnam;

            pred = tek;
            tek = chisl2 / znam2;
            n++;
        }

        chisl1 = 1.0f;
        znam1 = 1.0f;
        chisl2 = 2.0f;
        znam2 = 1.0f;

        pred = chisl1 / znam1;
        tek = chisl2 / znam2;

        for (int i = 3; i <= 100; i++)
        {
            float raznica = Math.Abs(tek - pred);

            if (raznica <= 0.001f)
            {
                Console.WriteLine($"Член {i}: {tek}, разница: {raznica}");
                break;
            }

            float noviyChisl = chisl1 + chisl2;
            float noviyZnam = znam1 + znam2;

            chisl1 = chisl2;
            znam1 = znam2;
            chisl2 = noviyChisl;
            znam2 = noviyZnam;

            pred = tek;
            tek = chisl2 / znam2;
        }
    }
}