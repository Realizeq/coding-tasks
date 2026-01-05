using System;
class Program
{
    static void Main()
    {
        int proizv = 1;
        int chislo;

        Console.WriteLine("Вводите положительные целые числа, 0 для завершения:");

        while (true)
        {
            chislo = int.Parse(Console.ReadLine());
            if (chislo == 0)
            {
                Console.WriteLine("0");
                break;
            }

            proizv *= chislo;
            Console.WriteLine(proizv);
        }
    }
}