using System;
class Program
{
    static void Main()
    {
        Console.Write("Курс доллара: ");
        float kurs = float.Parse(Console.ReadLine());

        Console.WriteLine("Доллары  Рубли");

        for (int dollars = 1; dollars <= 20; dollars++)
        {
            float rubles = dollars * kurs;
            Console.WriteLine($"{dollars,-8} {rubles,-10:F2}");
        }
    }
}