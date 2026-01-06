using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Введите k: ");
        int k = int.Parse(Console.ReadLine());

        Console.WriteLine($"Числа от {a} до {b} с {k} делителями:");

        for (int chislo = a; chislo <= b; chislo++)
        {
            int count = 0;
            for (int del = 1; del <= chislo; del++)
            {
                if (chislo % del == 0)
                    count++;
            }
            if (count == k)
                Console.WriteLine(chislo);
        }
    }
}