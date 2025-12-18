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
        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        int b = int.Parse(Console.ReadLine());

        int nod = NOD(a, b);
        int nok = a * b / nod;

        Console.WriteLine($"Наименьшее общее кратное: {nok}");
    }
}