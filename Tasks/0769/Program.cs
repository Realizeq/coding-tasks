using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 25, 8, 30, 12, 35, 18, 40, 5, 22 };

        int summaDo20 = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] <= 20)
            {
                summaDo20 += massiv[i];
            }
        }
        Console.WriteLine($"Сумма элементов <= 20: {summaDo20}");

        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());

        int summaBolsheA = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] > a)
            {
                summaBolsheA += massiv[i];
            }
        }
        Console.WriteLine($"Сумма элементов > {a}: {summaBolsheA}");
    }
}