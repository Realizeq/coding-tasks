using System;
class Program
{
    static void Main()
    {
        int count = 0;
        int number = 100;

        while (count < 10)
        {
            if (number % 10 == 7 && number % 9 == 0)
            {
                Console.Write($"{number} ");
                count++;
            }
            number++;
        }
    }
}