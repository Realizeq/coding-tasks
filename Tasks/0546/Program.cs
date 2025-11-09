using System;
class Program
{
    static void Main()
    {
        int last_index = 0;
        int first_index = 0;
        bool found_first = false;

        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"a{i}: ");
            int a = int.Parse(Console.ReadLine());

            if (a == 10)
            {
                last_index = i;
                if (!found_first)
                {
                    first_index = i;
                    found_first = true;
                }
            }
        }

        if (last_index > 0)
        {
            Console.WriteLine($"а) номер последнего: {last_index}");
            Console.WriteLine($"б) номер первого: {first_index}");
        }
        else
        {
            Console.WriteLine("числа 10 нет");
        }
    }
}