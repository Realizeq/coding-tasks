using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        int a = 1;
        int b = 1;
        int sum = 2;

        for (int i = 3; i <= n; i++)
        {
            int next = a + b;
            sum += next;
            a = b;
            b = next;
        }

        if (sum % 2 == 0)
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }
    }
}