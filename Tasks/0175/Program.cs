using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите размер a1 чемодана: ");
        float a1 = float.Parse(Console.ReadLine());

        Console.Write("Введите размер a2 чемодана: ");
        float a2 = float.Parse(Console.ReadLine());

        Console.Write("Введите размер a3 чемодана: ");
        float a3 = float.Parse(Console.ReadLine());

        Console.Write("Введите размер b1 коробки: ");
        float b1 = float.Parse(Console.ReadLine());

        Console.Write("Введите размер b2 коробки: ");
        float b2 = float.Parse(Console.ReadLine());

        Console.Write("Введите размер b3 коробки: ");
        float b3 = float.Parse(Console.ReadLine());

        if ((b1 <= a1 && b2 <= a2 && b3 <= a3) ||
            (b1 <= a1 && b2 <= a3 && b3 <= a2) ||
            (b1 <= a2 && b2 <= a1 && b3 <= a3) ||
            (b1 <= a2 && b2 <= a3 && b3 <= a1) ||
            (b1 <= a3 && b2 <= a1 && b3 <= a2) ||
            (b1 <= a3 && b2 <= a2 && b3 <= a1))
        {
            Console.WriteLine("Коробку можно поместить в чемодан");
        }
        else
        {
            Console.WriteLine("Коробку нельзя поместить в чемодан");
        }
    }
}