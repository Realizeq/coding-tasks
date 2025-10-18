using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Время прибытия поезда:");
        Console.Write("Часы: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Минуты: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Время отправления поезда:");
        Console.Write("Часы: ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("Минуты: ");
        int d = int.Parse(Console.ReadLine());

        Console.WriteLine("Время прихода пассажира:");
        Console.Write("Часы: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Минуты: ");
        int m = int.Parse(Console.ReadLine());

        int arrival = a * 60 + b;
        int departure = c * 60 + d;
        int passenger = n * 60 + m;

        if (passenger >= arrival && passenger < departure)
        {
            Console.WriteLine("Поезд стоит на платформе");
        }
        else
        {
            Console.WriteLine("Поезда нет на платформе");
        }
    }
}