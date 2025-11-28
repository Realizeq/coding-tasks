using System;
class Program
{
    static void Main()
    {
        int[] rost = { 185, 183, 182, 181, 180, 179, 178, 177, 176, 175, 174, 173, 172, 171, 170 };

        Console.WriteLine("Рост учеников:");
        for (int i = 0; i < rost.Length; i++)
        {
            Console.WriteLine($"{rost[i]}");
        }

        Console.Write("Введите рост нового ученика: ");
        int noviyRost = int.Parse(Console.ReadLine());

        int mesto = 0;
        while (mesto < rost.Length && rost[mesto] > noviyRost)
        {
            mesto++;
        }

        Console.WriteLine($"Новый ученик займет {mesto + 1} место");
    }
}