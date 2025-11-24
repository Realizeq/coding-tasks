using System;
class Program
{
    static void Main()
    {
        int[] rost = { 185, 183, 182, 181, 180, 179, 178, 177, 176, 175, 174, 173, 172, 171, 170, 169, 168, 167, 166, 165, 164, 163, 162, 161, 160 };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < rost.Length; i++)
        {
            Console.WriteLine($"{rost[i]}");
        }

        Console.WriteLine("1) Удален ученик по номеру:");
        Console.Write("Введите номер ученика: ");
        int nomer = int.Parse(Console.ReadLine());
        for (int i = nomer - 1; i < rost.Length - 1; i++)
        {
            rost[i] = rost[i + 1];
        }
        rost[rost.Length - 1] = 0;
        for (int i = 0; i < rost.Length; i++)
        {
            Console.WriteLine($"{rost[i]}");
        }

        Console.WriteLine("2) Удален ученик по росту:");
        Console.Write("Введите рост ученика: ");
        int rostUchenika = int.Parse(Console.ReadLine());
        int index = -1;
        for (int i = 0; i < rost.Length; i++)
        {
            if (rost[i] == rostUchenika)
            {
                index = i;
                break;
            }
        }
        if (index != -1)
        {
            for (int i = index; i < rost.Length - 1; i++)
            {
                rost[i] = rost[i + 1];
            }
            rost[rost.Length - 1] = 0;
        }
        for (int i = 0; i < rost.Length; i++)
        {
            Console.WriteLine($"{rost[i]}");
        }
    }
}