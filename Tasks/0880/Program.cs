using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 25, 8, 30, 12, 35, 18, 40, 5, 22, 40, 17, 30 };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        Console.Write("Введите первое число: ");
        int chislo1 = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int chislo2 = int.Parse(Console.ReadLine());

        int max = massiv[0];
        int maxIndex = 0;
        for (int i = 1; i < massiv.Length; i++)
        {
            if (massiv[i] > max)
            {
                max = massiv[i];
                maxIndex = i;
            }
        }

        int[] noviyMassiv = new int[massiv.Length + 2];
        for (int i = 0; i < maxIndex; i++)
        {
            noviyMassiv[i] = massiv[i];
        }
        noviyMassiv[maxIndex] = chislo2;
        noviyMassiv[maxIndex + 1] = massiv[maxIndex];
        noviyMassiv[maxIndex + 2] = chislo1;
        for (int i = maxIndex + 1; i < massiv.Length; i++)
        {
            noviyMassiv[i + 2] = massiv[i];
        }

        Console.WriteLine("После вставки:");
        for (int i = 0; i < noviyMassiv.Length; i++)
        {
            Console.WriteLine($"{noviyMassiv[i]}");
        }
    }
}