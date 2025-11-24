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

        Console.WriteLine("1) Удалены два ученика по номерам:");
        Console.Write("Введите номер первого ученика: ");
        int nomer1 = int.Parse(Console.ReadLine());
        Console.Write("Введите номер второго ученика: ");
        int nomer2 = int.Parse(Console.ReadLine());

        if (nomer1 > nomer2)
        {
            for (int i = nomer1 - 1; i < rost.Length - 1; i++)
            {
                rost[i] = rost[i + 1];
            }
            rost[rost.Length - 1] = 0;

            for (int i = nomer2 - 1; i < rost.Length - 1; i++)
            {
                rost[i] = rost[i + 1];
            }
            rost[rost.Length - 1] = 0;
        }
        else
        {
            for (int i = nomer2 - 1; i < rost.Length - 1; i++)
            {
                rost[i] = rost[i + 1];
            }
            rost[rost.Length - 1] = 0;

            for (int i = nomer1 - 1; i < rost.Length - 1; i++)
            {
                rost[i] = rost[i + 1];
            }
            rost[rost.Length - 1] = 0;
        }

        for (int i = 0; i < rost.Length; i++)
        {
            Console.WriteLine($"{rost[i]}");
        }

        Console.WriteLine("2) Удалены два ученика по росту:");
        Console.Write("Введите рост первого ученика: ");
        int rost1 = int.Parse(Console.ReadLine());
        Console.Write("Введите рост второго ученика: ");
        int rost2 = int.Parse(Console.ReadLine());

        int index1 = -1;
        int index2 = -1;

        for (int i = 0; i < rost.Length; i++)
        {
            if (rost[i] == rost1 && index1 == -1)
            {
                index1 = i;
            }
            if (rost[i] == rost2 && index2 == -1)
            {
                index2 = i;
            }
        }

        if (index1 != -1 && index2 != -1)
        {
            if (index1 > index2)
            {
                for (int i = index1; i < rost.Length - 1; i++)
                {
                    rost[i] = rost[i + 1];
                }
                rost[rost.Length - 1] = 0;

                for (int i = index2; i < rost.Length - 1; i++)
                {
                    rost[i] = rost[i + 1];
                }
                rost[rost.Length - 1] = 0;
            }
            else
            {
                for (int i = index2; i < rost.Length - 1; i++)
                {
                    rost[i] = rost[i + 1];
                }
                rost[rost.Length - 1] = 0;

                for (int i = index1; i < rost.Length - 1; i++)
                {
                    rost[i] = rost[i + 1];
                }
                rost[rost.Length - 1] = 0;
            }
        }

        for (int i = 0; i < rost.Length; i++)
        {
            Console.WriteLine($"{rost[i]}");
        }
    }
}