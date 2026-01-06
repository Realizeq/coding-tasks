using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        long sum = 0;
        for (int i = 1; i <= n; i++)
        {
            long stepen = 1;
            for (int j = 0; j < i; j++)
            {
                stepen *= i;
            }
            sum += stepen;
        }

        Console.WriteLine($"Сумма: {sum}");
    }
}