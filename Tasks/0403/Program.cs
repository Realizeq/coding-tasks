using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Введите цифру a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите цифру b: ");
        int b = int.Parse(Console.ReadLine());

        int posA = -1;
        int posB = -1;
        int positionFromEnd = 0;

        int temp = number;

        while (temp > 0)
        {
            positionFromEnd++;
            int digit = temp % 10;

            if (digit == a && posA == -1)
            {
                posA = positionFromEnd;
            }

            if (digit == b && posB == -1)
            {
                posB = positionFromEnd;
            }

            temp /= 10;
        }

        if (posA != -1 && posB != -1)
        {
            if (posA < posB)
            {
                Console.WriteLine($"{a}");
            }
            else
            {
                Console.WriteLine($"{b}");
            }
        }
        else
        {
            Console.WriteLine("Нет обеиХ");
        }
    }
}