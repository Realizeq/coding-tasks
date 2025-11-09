using System;
class Program
{
    static void Main()
    {
        int position = 16;
        int[] rost = new int[15];

        Console.WriteLine("рост 15 учеников (по убыванию):");
        for (int a = 0; a < 15; a++)
        {
            rost[a] = int.Parse(Console.ReadLine());
        }

        Console.Write("рост нового ученика: ");
        int new_rost = int.Parse(Console.ReadLine());

        int b = 0;
        while (b < 15 && new_rost <= rost[b])
        {
            b++;
        }
        position = b + 1;

        Console.WriteLine($"место в перечне: {position}");
    }
}