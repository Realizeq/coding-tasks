using System;
class Program
{
    static void Main()
    {
        double[] massiv = { 4.0, 9.0, 16.0, 25.0, 36.0, 49.0, 64.0, 81.0, 100.0 };

        Console.WriteLine("Массив:");
        for (int i = 0; i < massiv.Length; i++)
        {
            Console.WriteLine($"{massiv[i]}");
        }

        Console.WriteLine("а) Квадратный корень элемента:");
        Console.Write("Введите индекс элемента: ");
        int index = int.Parse(Console.ReadLine());
        double koren = Math.Sqrt(massiv[index]);
        Console.WriteLine($"Корень из {massiv[index]} = {koren}");

        Console.WriteLine("б) Среднее арифметическое двух элементов:");
        Console.Write("Введите индекс первого элемента: ");
        int index1 = int.Parse(Console.ReadLine());
        Console.Write("Введите индекс второго элемента: ");
        int index2 = int.Parse(Console.ReadLine());
        double srednee = (massiv[index1] + massiv[index2]) / 2;
        Console.WriteLine($"Среднее {massiv[index1]} и {massiv[index2]} = {srednee}");
    }
}