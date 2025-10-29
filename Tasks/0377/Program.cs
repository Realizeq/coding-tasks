using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        int b = int.Parse(Console.ReadLine());

        int koeff = 0;
        int temp = b;
        if (a != 0)
        {
            while (temp >= a)
            {
                temp -= a;
                koeff++;
            }
        }
        Console.WriteLine($"а) {koeff}");

        int ostatok = b;
        if (a != 0)
        {
            while (ostatok >= a)
            {
                ostatok -= a;
            }
        }
        Console.WriteLine($"б) {ostatok}");
    }
}