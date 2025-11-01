using System;
class Program
{
    static void Main()
    {
        int a = 12;
        int b = 18;

        int chislitel = a;
        int znamenatel = b;

        int temp_a = a;
        int temp_b = b;

        while (temp_b != 0)
        {
            int temp = temp_b;
            temp_b = temp_a % temp_b;
            temp_a = temp;
        }

        int nod = temp_a;
        int p = a / nod;
        int q = b / nod;

        Console.WriteLine($"сокращенная дробь {p}/{q}");
    }
}