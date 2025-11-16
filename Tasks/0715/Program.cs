using System;
class Program
{
    static void Main()
    {
        char[] massiv = new char[20];

        for (int i = 0; i < 20; i++)
        {
            massiv[i] = '#';
        }

        for (int i = 0; i < 20; i++)
        {
            Console.Write(massiv[i]);
        }
        Console.WriteLine();
    }
}