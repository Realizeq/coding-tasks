using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Введите p: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write($"Числа меньше {n} взаимно простые с {p}: ");
        for (int i = 1; i < n; i++)
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