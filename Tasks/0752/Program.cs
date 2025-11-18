using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

        Console.WriteLine("Массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        Console.WriteLine("а) Сумма всех элементов:");
        int summa = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            summa += massiv[i];
        }
        Console.WriteLine($"{summa}");

        Console.WriteLine("б) Произведение всех элементов:");
        int proizvedenie = 1;
        for (int i = 0; i < massiv.Length; i++)
        {
            proizvedenie *= massiv[i];
        }
        Console.WriteLine($"{proizvedenie}");

        Console.WriteLine("в) Сумма квадратов всех элементов:");
        int summaKvadratov = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            summaKvadratov += massiv[i] * massiv[i];
        }
        Console.WriteLine($"{summaKvadratov}");

        Console.WriteLine("г) Сумма шести первых элементов:");
        int summa6 = 0;
        for (int i = 0; i < 6; i++)
        {
            summa6 += massiv[i];
        }
        Console.WriteLine($"{summa6}");

        Console.WriteLine("д) Сумма элементов с k1 по k2:");
        Console.Write("Введите k1: ");
        int k1 = int.Parse(Console.ReadLine());
        Console.Write("Введите k2: ");
        int k2 = int.Parse(Console.ReadLine());
        int summaK = 0;
        for (int i = k1; i <= k2; i++)
        {
            summaK += massiv[i];
        }
        Console.WriteLine($"{summaK}");

        Console.WriteLine("е) Среднее арифметическое всех элементов:");
        double srednee = (double)summa / massiv.Length;
        Console.WriteLine($"{srednee}");

        Console.WriteLine("ж) Среднее арифметическое с s1 по s2:");
        Console.Write("Введите s1: ");
        int s1 = int.Parse(Console.ReadLine());
        Console.Write("Введите s2: ");
        int s2 = int.Parse(Console.ReadLine());
        int summaS = 0;
        for (int i = s1; i <= s2; i++)
        {
            summaS += massiv[i];
        }
        double sredneeS = (double)summaS / (s2 - s1 + 1);
        Console.WriteLine($"{sredneeS}");
    }
}