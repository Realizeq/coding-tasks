using System;
class Program
{
    static int SummaCifr(int chislo)
    {
        int sum = 0;
        while (chislo > 0)
        {
            sum += chislo % 10;
            chislo /= 10;
        }
        return sum;
    }

    static void Main()
    {
        Console.Write("Введите первое число: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int b = int.Parse(Console.ReadLine());

        int sumA = SummaCifr(a);
        int sumB = SummaCifr(b);

        if (sumA > sumB)
            Console.WriteLine($"В первом числе сумма цифр больше ({sumA} > {sumB})");
        else if (sumB > sumA)
            Console.WriteLine($"Во втором числе сумма цифр больше ({sumB} > {sumA})");
        else
            Console.WriteLine($"Суммы цифр равны ({sumA})");
    }
}