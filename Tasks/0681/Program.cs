using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите p: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Введите q: ");
        int q = int.Parse(Console.ReadLine());
        Console.Write($"Делители {q} взаимно простые с {p}: ");
        for (int i = 1; i <= q; i++)
        {
            if (q % i == 0)
            {
                int a = p;
                int b = i;

                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }

                if (a == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}