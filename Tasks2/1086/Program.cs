using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        Console.Write("Введите n1: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("Введите n2: ");
        int n2 = int.Parse(Console.ReadLine());

        if (n1 > 0 && n2 <= predlozhenie.Length && n1 <= n2)
        {
            string result = "";

            for (int i = 0; i < predlozhenie.Length; i++)
            {
                if (i < n1 - 1 || i > n2 - 1)
                {
                    result += predlozhenie[i];
                }
            }

            Console.WriteLine($"Результат: {result}");
        }
        else
        {
            Console.WriteLine("Некорректные значения n1 и n2");
        }
    }
}