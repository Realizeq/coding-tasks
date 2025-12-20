using System;
class Program
{
    static int NOD(int a, int b)
    {
        while (b != 0)
        {
            int ost = a % b;
            a = b;
            b = ost;
        }
        return a;
    }

    static void Main()
    {
        Console.Write("Введите первое число: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Введите третье число: ");
        int c = int.Parse(Console.ReadLine());

        int nod_ab = NOD(a, b);
        int nod_abc = NOD(nod_ab, c);

        Console.WriteLine($"Наибольший общий делитель: {nod_abc}");
    }
}