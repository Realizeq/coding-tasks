using System;
class Program
{
    static void Main()
    {
        int a = 56;
        int b = 98;
        int c = 42;

        int temp1 = a;
        int temp2 = b;
        int temp3 = c;

        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        int nod_ab = a;
        a = nod_ab;
        b = c;

        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        Console.WriteLine($"наибольший общий делитель чисел {temp1}, {temp2} и {temp3} равен {a}");
    }
}