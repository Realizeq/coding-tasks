using System;
class Program
{
    static void Main()
    {
        int count = 0;
        int number = 100;

        while (count < 15)
        {
            if (number % 19 == 0)
            {
                Console.Write($"{number} ");
                count++;
            }
            number++;
        }
    }
}