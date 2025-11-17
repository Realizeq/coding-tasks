using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120 };

        Console.WriteLine("а) Второй, четвертый и тд:");
        for (int i = 1; i < massiv.Length; i += 2)
        {
            Console.WriteLine($"[{i}] = {massiv[i]}");
        }

        Console.WriteLine("б) Третий, шестой и тд:");
        for (int i = 2; i < massiv.Length; i += 3)
        {
            Console.WriteLine($"[{i}] = {massiv[i]}");
        }
    }
}