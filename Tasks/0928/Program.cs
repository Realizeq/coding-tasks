using System;
class Program
{
    static void Main()
    {
        int n = 22424;
        int count = 0;

        for (int i = 0; i <= 9; i++)
        {
            int temp = n;
            bool found = false;

            while (temp > 0)
            {
                int digit = temp % 10;
                if (digit == i)
                {
                    found = true;
                    break;
                }
                temp = temp / 10;
            }

            if (found)
            {
                count++;
            }
        }

        Console.WriteLine($"В числе {n} количество различных цифр: {count}");
    }
}