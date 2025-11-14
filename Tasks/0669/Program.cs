using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        int summa = 0;

        for (int i = 1; i <= n; i++)
        {
            int stepen = 1;
            for (int j = 0; j < i; j++)
            {
                stepen *= i;
            }
            summa += stepen;
        }

        Console.WriteLine($"Сумма: {summa}");
    }
}