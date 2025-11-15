using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();

        int moneta = rand.Next(0, 2);

        if (moneta == 0)
        {
            Console.WriteLine("Орел");
        }
        else
        {
            Console.WriteLine("Решка");
        }
    }
}