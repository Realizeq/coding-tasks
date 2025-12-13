using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите символ: ");
        char c = Console.ReadLine()[0];

        if (c >= '0' && c <= '9')
        {
            Console.WriteLine($"Символ '{c}' является цифрой");
        }
        else
        {
            Console.WriteLine($"Символ '{c}' не является цифрой");
        }
    }
}