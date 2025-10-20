using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Введите третье число: ");
        int c = int.Parse(Console.ReadLine());

        string max, min, middle;

        if (a > b && a > c)
        {
            max = "первое";
            if (b > c)
            {
                min = "третье";
                middle = "второе";
            }
            else
            {
                min = "второе";
                middle = "третье";
            }
        }
        else if (b > a && b > c)
        {
            max = "второе";
            if (a > c)
            {
                min = "третье";
                middle = "первое";
            }
            else
            {
                min = "первое";
                middle = "третье";
            }
        }
        else
        {
            max = "третье";
            if (a > b)
            {
                min = "второе";
                middle = "первое";
            }
            else
            {
                min = "первое";
                middle = "второе";
            }
        }

        Console.WriteLine($"а) Большое: {max}");
        Console.WriteLine($"б) Маленькое: {min}");
        Console.WriteLine($"в) Среднее: {middle}");
    }
}