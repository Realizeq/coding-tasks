using System;
class Program
{
    static void Main()
    {
        int[] resultaty = { 120, 118, 115, 112, 110, 108, 105, 103, 100, 98, 95, 93, 90, 88, 85, 83, 80, 78, 75, 73, 70, 68, 65, 63, 60 };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < resultaty.Length; i++)
        {
            Console.WriteLine($"{resultaty[i]}");
        }

        int perviy = resultaty[0];
        int poziciya = 0;
        while (poziciya < resultaty.Length - 1 && perviy < resultaty[poziciya + 1])
        {
            resultaty[poziciya] = resultaty[poziciya + 1];
            poziciya++;
        }
        resultaty[poziciya] = perviy;

        Console.WriteLine("После упорядочивания:");
        for (int i = 0; i < resultaty.Length; i++)
        {
            Console.WriteLine($"{resultaty[i]}");
        }
    }
}