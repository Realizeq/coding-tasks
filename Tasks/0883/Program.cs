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

        Console.WriteLine("1) Вставлены по номерам:");
        Console.Write("Введите рост первого ученика: ");
        int rost1 = int.Parse(Console.ReadLine());
        Console.Write("Введите номер первого ученика: ");
        int nomer1 = int.Parse(Console.ReadLine());
        Console.Write("Введите рост второго ученика: ");
        int rost2 = int.Parse(Console.ReadLine());
        Console.Write("Введите номер второго ученика: ");
        int nomer2 = int.Parse(Console.ReadLine());

        int[] noviyMassiv = new int[rost.Length + 2];
        int index = 0;
        for (int i = 0; i < rost.Length; i++)
        {
            if (i == nomer1 - 1)
            {
                noviyMassiv[index] = rost1;
                index++;
            }
            if (i == nomer2 - 1)
            {
                noviyMassiv[index] = rost2;
                index++;
            }
            noviyMassiv[index] = rost[i];
            index++;
        }
        for (int i = 0; i < noviyMassiv.Length; i++)
        {
            Console.WriteLine($"{noviyMassiv[i]}");
        }

        Console.WriteLine("2) Вставлены по росту:");
        Console.Write("Введите рост первого ученика: ");
        rost1 = int.Parse(Console.ReadLine());
        Console.Write("Введите рост второго ученика: ");
        rost2 = int.Parse(Console.ReadLine());

        int poziciya1 = 0;
        while (poziciya1 < rost.Length && rost[poziciya1] > rost1)
        {
            poziciya1++;
        }

        int poziciya2 = 0;
        while (poziciya2 < rost.Length && rost[poziciya2] > rost2)
        {
            poziciya2++;
        }

        noviyMassiv = new int[rost.Length + 2];
        index = 0;
        for (int i = 0; i < rost.Length; i++)
        {
            if (i == poziciya1)
            {
                noviyMassiv[index] = rost1;
                index++;
            }
            if (i == poziciya2)
            {
                noviyMassiv[index] = rost2;
                index++;
            }
            noviyMassiv[index] = rost[i];
            index++;
        }
        for (int i = 0; i < noviyMassiv.Length; i++)
        {
            Console.WriteLine($"{noviyMassiv[i]}");
        }
    }
}