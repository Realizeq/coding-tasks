using System;
class Program
{
    static void Main()
    {
        int[] massiv = new int[10];
        int count = 0;
        int n = 100;

        while (count < 10)
        {
            bool prostoe = true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    prostoe = false;
                    break;
                }
            }

            if (prostoe)
            {
                massiv[count] = n;
                count++;
            }
            n++;
        }

        Console.WriteLine("Первые 10 простых чисел начиная с 100:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"[{i}] = {massiv[i]}");
        }
    }
}