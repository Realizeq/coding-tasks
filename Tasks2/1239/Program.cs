using System;
class Program
{
    static bool Kvadrat(int chislo)
    {
        if (chislo < 0) return false;
        int koren = (int)Math.Sqrt(chislo);
        return koren * koren == chislo;
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
            if (Kvadrat(a)) schet++;
        }

        Console.WriteLine($"Количество полных квадратов: {schet}");
    }
}