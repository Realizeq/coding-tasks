using System;
class Program
{
    static void Main()
    {
        int sum1 = 0;
        int sum2 = 0;

        Console.WriteLine("стоимости предметов первого набора:");
        for (int i = 1; i <= 8; i++)
        {
            Console.Write($"предмет {i}: ");
            int stoimost = int.Parse(Console.ReadLine());
            sum1 += stoimost;
        }

        Console.WriteLine("стоимости предметов второго набора:");
        for (int i = 1; i <= 8; i++)
        {
            Console.Write($"предмет {i}: ");
            int stoimost = int.Parse(Console.ReadLine());
            sum2 += stoimost;
        }

        if (sum1 < sum2) Console.WriteLine("первый");
        else if (sum2 < sum1) Console.WriteLine("второй");
        else Console.WriteLine("одинаково");
    }
}