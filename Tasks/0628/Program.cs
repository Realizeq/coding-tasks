using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("а)");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("8 8 8");
        }

        Console.WriteLine("б)");
        for (int i = 1; i <= 7; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("в)");
        for (int i = 1; i <= 8; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(i * 10 + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("г)");
        for (int i = 1; i <= 8; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(i * 10 + 2 + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("д)");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 2; j <= 20; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("е)");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 15; j >= 3; j--)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("ж)");
        for (int i = 6; i >= 1; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("0 ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("з)");
        for (int i = 8; i >= 1; i--)
        {
            for (int j = 8; j >= 9 - i; j--)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("и)");
        for (int i = 2; i <= 9; i++)
        {
            for (int j = i; j <= 10; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("й)");
        for (int i = 2; i <= 10; i++)
        {
            for (int j = 2; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("к)");
        for (int i = 3; i <= 6; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("л)");
        for (int i = 21; i <= 25; i++)
        {
            for (int j = 21; j <= i; j++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("м)");
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 0; j < 9 - i; j++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("н)");
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(i * 10 + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("о)");
        for (int i = 5; i <= 9; i++)
        {
            for (int j = 0; j < 10 - i; j++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("п)");
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 0; j < 6 - i; j++)
            {
                Console.Write(i * 5 + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("р)");
        for (int i = 0; i <= 6; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                Console.Write((10 + i) * 10 + j + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("с)");
        for (int i = 5; i >= 2; i--)
        {
            for (int j = 1; j <= 8; j++)
            {
                Console.Write(i * 10 + j + " ");
            }
            Console.WriteLine();
        }
    }
}