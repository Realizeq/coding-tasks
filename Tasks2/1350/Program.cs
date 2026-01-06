using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите n (<= 27): ");
        int n = int.Parse(Console.ReadLine());

        for (int cifra1 = 1; cifra1 <= 9; cifra1++)
        {
            for (int cifra2 = 0; cifra2 <= 9; cifra2++)
            {
                for (int cifra3 = 0; cifra3 <= 9; cifra3++)
                {
                    if (cifra1 + cifra2 + cifra3 == n)
                    {
                        int chislo = cifra1 * 100 + cifra2 * 10 + cifra3;
                        Console.WriteLine(chislo);
                    }
                }
            }
        }
    }
}