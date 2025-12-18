using System;
class Program
{
    static int Fact(int n)
    {
        int f = 1;
        for (int i = 2; i <= n; i++)
        {
            f *= i;
        }
        return f;
    }

    static void Main()
    {
        int chislitel = 2 * Fact(5) + 3 * Fact(8);
        int znamenatel = Fact(6) + Fact(4);

        float rezultat = (float)chislitel / znamenatel;

        Console.WriteLine($"Результат = {rezultat}");
    }
}