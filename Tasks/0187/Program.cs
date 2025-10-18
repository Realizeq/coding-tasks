using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Введите c: ");
        int c = int.Parse(Console.ReadLine());

        Console.Write("Введите d: ");
        int d = int.Parse(Console.ReadLine());

        int sum1 = a + b;
        int sum2 = c + d;

        if (sum1 % 2 == sum2 % 2)
        {
            Console.WriteLine("Поля одного цвета");
        }
        else
        {
            Console.WriteLine("Поля разного цвета");
        }
    }
}