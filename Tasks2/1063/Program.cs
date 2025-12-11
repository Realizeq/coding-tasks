using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string stroka = Console.ReadLine();

        Console.Write("Введите номер m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите номер n: ");
        int n = int.Parse(Console.ReadLine());

        if (m > 0 && n <= stroka.Length && m <= n && n - m + 1 == 3)
        {
            string substring = stroka.Substring(m - 1, 3);

            if (substring == "666")
            {
                Console.WriteLine($"Подстрока с позиции {m} до {n}: {substring} - это число 666");
            }
            else
            {
                Console.WriteLine($"Подстрока с позиции {m} до {n}: {substring} - это не число 666");
            }
        }
        else
        {
            Console.WriteLine("Некорректные параметры m и n");
        }
    }
}