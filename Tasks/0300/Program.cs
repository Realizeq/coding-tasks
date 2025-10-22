using System;
class Program
{
    static void Main()
    {
        int a = 1;
        int b = 1;

        for (int i = 3; i <= 10; i++)
        {
            int next = a + b;
            Console.WriteLine($"{i} й член: {next}");
            a = b;
            b = next;
        }
    }
}