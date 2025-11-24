using System;
class Program
{
    static void Main()
    {
        int[] rost = { 185, 183, 182, 181, 180, 179, 178, 177, 176, 175, 174, 173, 172, 171, 170 };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < rost.Length; i++)
        {
            Console.WriteLine($"{rost[i]}");
        }

        Console.WriteLine("1) Вставлен по номеру:");
        Console.Write("Введите рост нового ученика: ");
        int noviyRost = int.Parse(Console.ReadLine());
        Console.Write("Введите номер для вставки: ");
        int nomer = int.Parse(Console.ReadLine());

        int[] noviyMassiv = new int[rost.Length + 1];
        for (int i = 0; i < nomer - 1; i++)
        {
            noviyMassiv[i] = rost[i];
        }
        noviyMassiv[nomer - 1] = noviyRost;
        for (int i = nomer - 1; i < rost.Length; i++)
        {
            noviyMassiv[i + 1] = rost[i];
        }
        for (int i = 0; i < noviyMassiv.Length; i++)
        {
            Console.WriteLine($"{noviyMassiv[i]}");
        }

        Console.WriteLine("2) Вставлен по росту:");
        Console.Write("Введите рост нового ученика: ");
        noviyRost = int.Parse(Console.ReadLine());

        int poziciya = 0;
        while (poziciya < rost.Length && rost[poziciya] > noviyRost)
        {
            poziciya++;
        }

        noviyMassiv = new int[rost.Length + 1];
        for (int i = 0; i < poziciya; i++)
        {
            noviyMassiv[i] = rost[i];
        }
        noviyMassiv[poziciya] = noviyRost;
        for (int i = poziciya; i < rost.Length; i++)
        {
            noviyMassiv[i + 1] = rost[i];
        }
        for (int i = 0; i < noviyMassiv.Length; i++)
        {
            Console.WriteLine($"{noviyMassiv[i]}");
        }
    }
}