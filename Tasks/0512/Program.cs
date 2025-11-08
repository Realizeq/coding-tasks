using System;
class Program
{
    static void Main()
    {
        int count = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"a{i}: ");
            int a = int.Parse(Console.ReadLine());

            if (a > 0) count++;
        }

        if (count <= 5) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
}