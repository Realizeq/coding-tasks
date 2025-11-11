using System;
class Program
{
    static void Main()
    {
        bool valid = true;

        Console.Write("первое число: ");
        int prev = int.Parse(Console.ReadLine());

        int j = 2;
        while (j <= 20 && valid)
        {
            Console.Write($"число {j}: ");
            int current = int.Parse(Console.ReadLine());

            int prev_right = prev % 10;
            int current_left = current / 10;

            if (prev_right != current_left)
            {
                valid = false;
            }

            prev = current;
            j++;
        }

        if (valid) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
}