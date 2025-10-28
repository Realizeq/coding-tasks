using System;
class Program
{
    static void Main()
    {
        int i = 10;
        while (i <= 30)
        {
            Console.WriteLine(i);
            i++;
        }

        Console.WriteLine();

        int j = 10;
        do
        {
            Console.WriteLine(j);
            j++;
        } while (j <= 30);
    }
}