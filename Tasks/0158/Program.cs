using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int num2 = int.Parse(Console.ReadLine());

        if (num1 % num2 == 0)
        {
            Console.WriteLine($"{num2} является делителем {num1}");
        }
        else if (num2 % num1 == 0)
        {
            Console.WriteLine($"{num1} является делителем {num2}");
        }
        else
        {
            Console.WriteLine("Ни одно число не является делителем другого");
        }
    }
}