using System;
class Program
{
    static bool StepPyat(int chislo)
    {
        if (chislo <= 0) return false;
        while (chislo > 1)
        {
            if (chislo % 5 != 0) return false;
            chislo /= 5;
        }
        return true;
    }

    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        int schet = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите число a{i + 1}: ");
            int a = int.Parse(Console.ReadLine());
            if (StepPyat(a)) schet++;
        }

        Console.WriteLine($"Количество степеней пятерки: {schet}");
    }
}