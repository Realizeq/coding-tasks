using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите b: ");
        int b = int.Parse(Console.ReadLine());

        string result;

        if (b % a == 0)
        {
            result = "a является делителем b";
        }
        else if (a % b == 0)
        {
            result = "b является делителем a";
        }
        else
        {
            result = "ни одно не является делителем другого";
        }

        Console.WriteLine(result);
    }
}