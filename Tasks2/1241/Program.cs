using System;
class Program
{
    static bool Prostoe(int chislo)
    {
        if (chislo < 2) return false;
        for (int i = 2; i <= Math.Sqrt(chislo); i++)
        {
            if (chislo % i == 0) return false;
        }
        return true;
    }

    static void Main()
    {
        for (int i = 100; i <= 999; i++)
        {
            if (Prostoe(i))
            {
                Console.Write($"{i} ");
            }
        }
    }
}