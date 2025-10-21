using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите число (1-9): ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 9; i++)
        {
            int result = n * i;
            Console.WriteLine($"{n} x {i} = {result}");
        }
    }
}