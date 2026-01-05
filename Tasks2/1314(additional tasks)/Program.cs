using System;
class Program
{
    static void Main()
    {
        int sum = 0;
        int count = 0;
        int chislo;

        Console.WriteLine("Вводите целые числа, 0 для завершения:");

        do
        {
            chislo = int.Parse(Console.ReadLine());
            if (chislo != 0)
            {
                sum += chislo;
                count++;
            }
        }
        while (chislo != 0);

        Console.WriteLine($"Сумма: {sum}");
        Console.WriteLine($"Количество: {count}");
    }
}