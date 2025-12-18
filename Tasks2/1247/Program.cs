using System;
class Program
{
    static bool EstVmassive(int[] m, int chislo)
    {
        for (int i = 0; i < m.Length; i++)
        {
            if (m[i] == chislo) return true;
        }
        return false;
    }

    static void Main()
    {
        int[] m1 = { 1, 3, 5, 7 };
        int[] m2 = { 2, 3, 6, 8 };
        int[] m3 = { 3, 4, 5 };

        int sovp1 = 0;
        int sovp2 = 0;

        for (int i = 0; i < m3.Length; i++)
        {
            if (EstVmassive(m1, m3[i])) sovp1++;
            if (EstVmassive(m2, m3[i])) sovp2++;
        }

        if (sovp1 > sovp2)
            Console.WriteLine($"В m1 больше совпадений ({sovp1} > {sovp2})");
        else if (sovp2 > sovp1)
            Console.WriteLine($"В m2 больше совпадений ({sovp2} > {sovp1})");
        else
            Console.WriteLine($"Совпадений поровну ({sovp1})");
    }
}