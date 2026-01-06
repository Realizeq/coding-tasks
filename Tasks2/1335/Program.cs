using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        for (int chislo = 1; chislo <= n; chislo++)
        {
            int count = 0;
            for (int del = 1; del <= chislo; del++)
            {
                if (chislo % del == 0)
                    count++;
            }
            Console.Write(chislo);
            for (int i = 0; i < count; i++)
                Console.Write("+");
            Console.WriteLine();
        }
    }
}