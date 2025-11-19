using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 25, 15, 30, 15, 35, 40, 15, 45, 15 };

        int poslednii = massiv[massiv.Length - 1];
        int countOtlichnyh = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] != poslednii)
            {
                countOtlichnyh++;
            }
        }
        Console.WriteLine($"Элементов отличных от последнего: {countOtlichnyh}");

        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());

        int countKratnyh = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] % a == 0)
            {
                countKratnyh++;
            }
        }
        Console.WriteLine($"Элементов кратных {a}: {countKratnyh}");
    }
}