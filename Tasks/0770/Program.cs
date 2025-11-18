using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 15, 24, 7, 30, 13, 35, 18, 41, 6, 22 };

        int summaNechetnyh = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] % 2 != 0)
            {
                summaNechetnyh += massiv[i];
            }
        }
        Console.WriteLine($"Сумма нечетных: {summaNechetnyh}");

        Console.Write("Введите число для кратности: ");
        int kratnoe = int.Parse(Console.ReadLine());

        int summaKratnyh = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] % kratnoe == 0)
            {
                summaKratnyh += massiv[i];
            }
        }
        Console.WriteLine($"Сумма кратных {kratnoe}: {summaKratnyh}");

        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        int b = int.Parse(Console.ReadLine());

        int summaKratnyhAB = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] % a == 0 || massiv[i] % b == 0)
            {
                summaKratnyhAB += massiv[i];
            }
        }
        Console.WriteLine($"Сумма кратных {a} или {b}: {summaKratnyhAB}");
    }
}