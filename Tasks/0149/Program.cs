using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        float number = float.Parse(Console.ReadLine());

        if (number > -5 && number < 3)
        {
            Console.WriteLine($"Число {number} принадлежит интервалу (-5, 3)");
        }
        else
        {
            Console.WriteLine($"Число {number} не принадлежит интервалу (-5, 3)");
        }
    }
}