using System;
class Program
{
    static void Main()
    {
        int a = 56;
        int b = 98;

        int temp1 = a;
        int temp2 = b;

        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        Console.WriteLine($"наибольший общий делитель чисел {temp1} и {temp2} = {a}");
    }
}