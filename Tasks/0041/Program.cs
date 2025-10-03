using System;
class program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число: ");
        float num1 = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Введите второе число: ");
        float num2 = Convert.ToSingle(Console.ReadLine());

        float sum = num1 + num2;
        float diff = num2 - num2;
        float mul = num1 * num2;
        float div = num1 / num2;

        Console.WriteLine($"Сумма: {sum}");
        Console.WriteLine($"Сумма: {diff}");
        Console.WriteLine($"Сумма: {mul}");
        Console.WriteLine($"Сумма: {div}");
    }
}