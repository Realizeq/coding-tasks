using System;
class Program
{
    static void Main()
    {
        int s = 0;
        int k = 0;

        while (s < 1024)
        {
            s = s + 10;
            k = k + 1;
        }

        Console.WriteLine(k);
    }
}