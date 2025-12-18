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
        for (int i = 2; i <= 198; i++)
        {
            if (Prostoe(i) && Prostoe(i + 2))
            {
                Console.WriteLine($"{i} и {i + 2}");
            }
        }
    }
}