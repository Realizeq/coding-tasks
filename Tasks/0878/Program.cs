using System;
class Program
{
    static void Main()
    {
        int[] vysota = { 8848, 8611, 8586, 8516, 8485, 8201, 8167, 8156, 8126, 8091, 8080, 8068, 8047, 8035, 8013, 7952, 7925, 7892, 7852, 7821 };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < vysota.Length; i++)
        {
            Console.WriteLine($"{vysota[i]}");
        }

        Console.Write("Введите высоту новой вершины: ");
        int novayaVysota = int.Parse(Console.ReadLine());
        Console.Write("Введите позицию для вставки: ");
        int poziciya = int.Parse(Console.ReadLine());

        int[] noviyMassiv = new int[vysota.Length + 1];
        for (int i = 0; i < poziciya; i++)
        {
            noviyMassiv[i] = vysota[i];
        }
        noviyMassiv[poziciya] = novayaVysota;
        for (int i = poziciya; i < vysota.Length; i++)
        {
            noviyMassiv[i + 1] = vysota[i];
        }

        Console.WriteLine("Новый массив:");
        for (int i = 0; i < noviyMassiv.Length; i++)
        {
            Console.WriteLine($"{noviyMassiv[i]}");
        }
    }
}