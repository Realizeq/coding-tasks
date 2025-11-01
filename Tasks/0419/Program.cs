using System;
class Program
{
    static void Main()
    {
        int n = 81;

        int temp = n;
        while (temp % 3 == 0 && temp > 1)
        {
            temp /= 3;
        }
        if (temp == 1) Console.WriteLine("а) является");
        else Console.WriteLine("а) не является");

        temp = n;
        while (temp % 5 == 0 && temp > 1)
        {
            temp /= 5;
        }
        if (temp == 1) Console.WriteLine("б) является");
        else Console.WriteLine("б) не является");
    }
}