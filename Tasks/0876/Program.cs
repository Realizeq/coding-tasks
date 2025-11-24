using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 25, 8, 30, 12, 35, 18, 40, 5, 22 };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        Console.WriteLine("а) Вставлено 10 после второго элемента:");
        int[] noviyMassiv = new int[massiv.Length + 1];
        for (int i = 0; i <= 2; i++)
        {
            noviyMassiv[i] = massiv[i];
        }
        noviyMassiv[3] = 10;
        for (int i = 3; i < massiv.Length; i++)
        {
            noviyMassiv[i + 1] = massiv[i];
        }
        for (int i = 0; i < noviyMassiv.Length; i++)
        {
            Console.WriteLine($"{noviyMassiv[i]}");
        }

        Console.WriteLine("б) Вставлено 100 после m-го элемента:");
        Console.Write("Введите m: ");
        int m = int.Parse(Console.ReadLine());
        noviyMassiv = new int[massiv.Length + 1];
        for (int i = 0; i <= m; i++)
        {
            noviyMassiv[i] = massiv[i];
        }
        noviyMassiv[m + 1] = 100;
        for (int i = m + 1; i < massiv.Length; i++)
        {
            noviyMassiv[i + 1] = massiv[i];
        }
        for (int i = 0; i < noviyMassiv.Length; i++)
        {
            Console.WriteLine($"{noviyMassiv[i]}");
        }
    }
}