using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите количество грибов: ");
        int k = int.Parse(Console.ReadLine());

        if (k % 10 == 1 && k % 100 != 11)
        {
            Console.WriteLine($"мы нашли {k} гриб в лесу");
        }
        else if (k % 10 >= 2 && k % 10 <= 4 && (k % 100 < 10 || k % 100 >= 20))
        {
            Console.WriteLine($"мы нашли {k} гриба в лесу");
        }
        else
        {
            Console.WriteLine($"мы нашли {k} грибов в лесу");
        }
    }
}