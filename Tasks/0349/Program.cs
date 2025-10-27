using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        int b = int.Parse(Console.ReadLine());

        int quotient = 0;
        int temp = a;
        while (temp >= b)
        {
            temp -= b;
            quotient++;
        }
        Console.WriteLine($"а) {quotient}");

        int remainder = a;
        while (remainder >= b)
        {
            remainder -= b;
        }
        Console.WriteLine($"б) {remainder}");
    }
}