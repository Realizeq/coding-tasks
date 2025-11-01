using System;
class Program
{
    static void Main()
    {
        int n = 15;
        int f = 3;
        int s = 4;

        if ((n - f) % s == 0 && n >= f)
        {
            Console.WriteLine("является");
        }
        else
        {
            Console.WriteLine("не является");
        }
    }
}