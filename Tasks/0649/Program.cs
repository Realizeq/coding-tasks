using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        for (int chislo = 1; chislo <= n; chislo++)
        {
            int deliteli = 0;

            for (int i = 1; i <= chislo; i++)
            {
                if (chislo % i == 0)
                {
                    deliteli++;
                }
            }

            Console.Write(chislo);

            for (int i = 0; i < deliteli; i++)
            {
                Console.Write("+");
            }

            Console.WriteLine();
        }
    }
}