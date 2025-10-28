using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        int b = int.Parse(Console.ReadLine());

        int i = a;
        while (i >= b)
        {
            Console.WriteLine(Math.Sqrt(i));
            i--;
        }

        Console.WriteLine();

        int j = a;
        do
        {
            Console.WriteLine(Math.Sqrt(j));
            j--;
        } while (j >= b);
    }
}