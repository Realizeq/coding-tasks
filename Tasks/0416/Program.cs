using System;
class Program
{
    static void Main()
    {
        int n = 55;

        if (n == 0 || n == 1)
        {
            Console.WriteLine("является");
            return;
        }

        int a = 0;
        int b = 1;
        int c = a + b;

        while (c < n)
        {
            a = b;
            b = c;
            c = a + b;
        }

        if (c == n)
        {
            Console.WriteLine("является");
        }
        else
        {
            Console.WriteLine("не является");
        }
    }
}