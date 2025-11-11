using System;
class Program
{
    static void Main()
    {
        int max_age = 0;
        int min_age = int.MaxValue;
        int max_index = 0;
        int min_index = 0;

        Console.Write("количество людей: ");
        int n = int.Parse(Console.ReadLine());

        for (int j = 1; j <= n; j++)
        {
            Console.Write($"человек {j}: ");
            int age = int.Parse(Console.ReadLine());

            if (age > max_age)
            {
                max_age = age;
                max_index = j;
            }

            if (age < min_age)
            {
                min_age = age;
                min_index = j;
            }
        }

        if (max_index < min_index) Console.WriteLine("самый старший");
        else if (min_index < max_index) Console.WriteLine("самый молодой");
        else Console.WriteLine("один человек");
    }
}