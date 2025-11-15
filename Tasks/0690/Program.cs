using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();

        Console.WriteLine("а) Два разных числа:");
        int a1 = rand.Next(0, 2);
        int b1 = rand.Next(0, 3);
        Console.WriteLine($"a = {a1}, b = {b1}");

        Console.WriteLine("б) Три разных числа:");
        int a2 = rand.Next(1, 3);
        int b2 = rand.Next(0, 3);
        int c2 = rand.Next(1, 4);
        Console.WriteLine($"a = {a2}, b = {b2}, c = {c2}");

        Console.WriteLine("в) 15 чисел (7 двоек и 8 троек):");
        int[] chisla = new int[15];
        for (int i = 0; i < 7; i++)
        {
            chisla[i] = 2;
        }
        for (int i = 7; i < 15; i++)
        {
            chisla[i] = 3;
        }

        for (int i = 0; i < 15; i++)
        {
            int index = rand.Next(0, 15);
            int temp = chisla[i];
            chisla[i] = chisla[index];
            chisla[index] = temp;
        }

        for (int i = 0; i < 15; i++)
        {
            Console.WriteLine(chisla[i]);
        }
    }
}