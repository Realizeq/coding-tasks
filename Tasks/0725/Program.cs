using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        int[] massiv = new int[6];

        int chislo = n;
        int index = 0;

        while (chislo > 0 && index < 6)
        {
            massiv[index] = chislo % 10;
            chislo /= 10;
            index++;
        }
        Console.WriteLine("в обратном порядке:");
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine($"[{i}] = {massiv[i]}");
        }
    }
}