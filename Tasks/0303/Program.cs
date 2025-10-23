using System;
class Program
{
    static void Main()
    {
        int cells = 1;

        for (int hours = 3; hours <= 24; hours += 3)
        {
            cells *= 2;
            Console.WriteLine($"{hours} часов - {cells} клеток");
        }
    }
}