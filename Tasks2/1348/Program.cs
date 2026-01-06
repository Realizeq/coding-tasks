using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите m: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = 1; i <= m; i++)
        {
            int stepen = 1;
            for (int j = 0; j < n; j++)
            {
                stepen *= i;
            }
            sum += stepen;
        }

        Console.WriteLine($"Сумма: {sum}");
    }
}