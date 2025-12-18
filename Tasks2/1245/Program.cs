using System;
class Program
{
    static int KolvoCifr(int chislo)
    {
        int kol = 0;
        while (chislo > 0)
        {
            kol++;
            chislo /= 10;
        }
        return kol;
    }

    static void Main()
    {
        Console.Write("Введите первое число: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int b = int.Parse(Console.ReadLine());

        int kolA = KolvoCifr(a);
        int kolB = KolvoCifr(b);

        if (kolA > kolB)
            Console.WriteLine($"В первом числе больше цифр ({kolA} > {kolB})");
        else if (kolB > kolA)
            Console.WriteLine($"Во втором числе больше цифр ({kolB} > {kolA})");
        else
            Console.WriteLine($"Количество цифр одинаково ({kolA})");
    }
}