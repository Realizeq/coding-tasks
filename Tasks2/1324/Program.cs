using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите a (1 < a <= 1.5): ");
        float a = float.Parse(Console.ReadLine());

        int znamen = 2;
        float chislo;

        do
        {
            chislo = 1 + 1.0f / znamen;
            if (chislo >= a)
                Console.WriteLine(chislo);
            znamen++;
        }
        while (chislo >= a);
    }
}