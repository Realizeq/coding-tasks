using System;
class Program
{
    static void Main()
    {
        float a = 0.3f;

        Console.WriteLine($"a = {a}");
        Console.WriteLine("Поиск первого числа меньше a:");

        int znam = 1;
        bool nashel = false;

        while (!nashel)
        {
            float chislo = 1.0f / znam;

            if (chislo < a)
            {
                Console.WriteLine($"Первое число меньше a: 1/{znam} = {chislo}");
                nashel = true;
            }
            znam++;
        }

        for (int i = 1; i <= 100; i++)
        {
            float drob = 1.0f / i;
            if (drob < a)
            {
                Console.WriteLine($"Первое число меньше a: 1/{i} = {drob}");
                break;
            }
        }
    }
}