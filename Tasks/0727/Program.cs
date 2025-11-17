using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("а) Арифметическая прогрессия:");
        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите p: ");
        int p = int.Parse(Console.ReadLine());

        int[] massivA = new int[10];
        massivA[0] = a;

        for (int i = 1; i < 10; i++)
        {
            massivA[i] = massivA[i - 1] + p;
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"[{i}] = {massivA[i]}");
        }

        Console.WriteLine("б) Геометрическая прогрессия:");
        Console.Write("Введите a: ");
        int a2 = int.Parse(Console.ReadLine());
        Console.Write("Введите z: ");
        int z = int.Parse(Console.ReadLine());

        int[] massivB = new int[20];
        massivB[0] = a2;

        for (int i = 1; i < 20; i++)
        {
            massivB[i] = massivB[i - 1] * z;
        }

        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine($"[{i}] = {massivB[i]}");
        }
    }
}