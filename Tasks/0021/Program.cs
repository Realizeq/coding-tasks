using System;
class program
{
    static void Main()
    {
        Console.Write("Введите значение стороны квадрата: ");
        float side = Convert.ToSingle(Console.ReadLine());

        float per = 4 * side; // Вычисление периметра 

        Console.WriteLine($"Периметр квадрата со стороной {side}, равен {per}");
    }
}