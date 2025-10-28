using System;
class Program
{
    static void Main()
    {
        int count = 0;
        int number = 500;

        while (count < 20)
        {
            if (number % 13 == 0 || number % 17 == 0)
            {
                Console.Write($"{number} ");
                count++;
            }
            number++;
        }
    }
}