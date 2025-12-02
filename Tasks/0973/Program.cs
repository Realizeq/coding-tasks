using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите название города: ");
        string gorod = Console.ReadLine();

        int dlina = gorod.Length;

        if (dlina % 2 == 0)
        {
            Console.WriteLine($"В названии {dlina} символов - четное количество");
        }
        else
        {
            Console.WriteLine($"В названии {dlina} символов - нечетное количество");
        }
    }
}