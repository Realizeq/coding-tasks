using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Вариант 1 - ввод по строкам:");

        int sum1 = 0;
        for (int uchenik = 1; uchenik <= 12; uchenik++)
        {
            Console.WriteLine($"Ученик {uchenik}:");
            Console.Write("Оценка по предмету 1: ");
            int ocenka1 = int.Parse(Console.ReadLine());
            Console.Write("Оценка по предмету 2: ");
            int ocenka2 = int.Parse(Console.ReadLine());
            Console.Write("Оценка по предмету 3: ");
            int ocenka3 = int.Parse(Console.ReadLine());

            int summaUchenika = ocenka1 + ocenka2 + ocenka3;
            sum1 += summaUchenika;
            Console.WriteLine($"Сумма оценок ученика {uchenik}: {summaUchenika}");
        }
        Console.WriteLine($"Общая сумма всех оценок: {sum1}");

        Console.WriteLine("Вариант 2 - ввод по столбцам:");

        int sum2 = 0;
        for (int predmet = 1; predmet <= 3; predmet++)
        {
            Console.WriteLine($"Предмет {predmet}:");
            for (int uchenik = 1; uchenik <= 12; uchenik++)
            {
                Console.Write($"Оценка ученика {uchenik}: ");
                int ocenka = int.Parse(Console.ReadLine());
                sum2 += ocenka;
            }
        }
        Console.WriteLine($"Общая сумма всех оценок: {sum2}");
    }
}