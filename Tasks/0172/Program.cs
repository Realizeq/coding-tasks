using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите размер конверта по горизонтали: ");
        float a = float.Parse(Console.ReadLine());

        Console.Write("Введите размер конверта по вертикали: ");
        float b = float.Parse(Console.ReadLine());

        Console.Write("Введите размер открытки по горизонтали: ");
        float c = float.Parse(Console.ReadLine());

        Console.Write("Введите размер открытки по вертикали: ");
        float d = float.Parse(Console.ReadLine());

        if ((c + 2 <= a && d + 2 <= b) || (c + 2 <= b && d + 2 <= a))
        {
            Console.WriteLine("Открытка помещается в конверт");
        }
        else
        {
            Console.WriteLine("Открытка не помещается в конверт");
        }
    }
}