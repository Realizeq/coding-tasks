using System;
class Program
{
    static void Main()
    {
        int n = 100;
        int[] money = { 64, 32, 16, 8, 4, 2, 1 };

        Console.WriteLine($"нужно заплатить сумму: {n}");
        Console.WriteLine("купюры:");

        for (int i = 0; i < money.Length; i++)
        {
            int count = n / money[i];
            if (count > 0)
            {
                Console.WriteLine($"{money[i]} - {count} шт");
                n = n % money[i];
            }
        }
    }
}