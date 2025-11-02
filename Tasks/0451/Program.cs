using System;
class Program
{
    static void Main()
    {
        int proizvedenie = 1;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"введите число a{i}: ");
            int a = int.Parse(Console.ReadLine());
            proizvedenie *= a;
        }

        if (proizvedenie < 10000) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
}