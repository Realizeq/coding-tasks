using System;
class Program
{
    static bool Palindrom(int n)
    {
        int orig = n;
        int obrat = 0;

        while (n > 0)
        {
            obrat = obrat * 10 + n % 10;
            n /= 10;
        }

        return orig == obrat;
    }

    static void Main()
    {
        Console.Write("Введите первое число: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int b = int.Parse(Console.ReadLine());

        bool palA = Palindrom(a);
        bool palB = Palindrom(b);

        if (palA && palB)
            Console.WriteLine("Оба числа являются палиндромами");
        else if (palA)
            Console.WriteLine($"Только первое число ({a}) является палиндромом");
        else if (palB)
            Console.WriteLine($"Только второе число ({b}) является палиндромом");
        else
            Console.WriteLine("Ни одно из чисел не является палиндромом");
    }
}