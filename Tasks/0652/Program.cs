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
            int deliteli = 0;

            for (int i = 1; i <= chislo; i++)
            {
                if (chislo % i == 0)
                {
                    deliteli++;
                }
            }

            if (deliteli == k)
            {
                Console.WriteLine(chislo);
            }
        }
    }
}