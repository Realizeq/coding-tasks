using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите факториал: ");
        int factorial = int.Parse(Console.ReadLine());

        int number = 1;
        int product = 1;

        while (product < factorial)
        {
            number++;
            product *= number;
        }

        Console.WriteLine($"{number}");
    }
}