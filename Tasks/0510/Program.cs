using System;
class Program
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        int count1 = 0;
        int count2 = 0;
        int count3 = 0;
        int count4 = 0;

        int prev = int.Parse(Console.ReadLine());

        for (int i = 2; i <= n; i++)
        {
            int current = int.Parse(Console.ReadLine());

            if (prev == current) count1++;
            if (prev == 0 && current == 0) count2++;
            if (prev % 2 == 0 && current % 2 == 0) count3++;
            if (prev % 10 == 5 && current % 10 == 5) count4++;

            prev = current;
        }

        Console.WriteLine($"а) {count1}");
        Console.WriteLine($"б) {count2}");
        Console.WriteLine($"в) {count3}");
        Console.WriteLine($"г) {count4}");
    }
}