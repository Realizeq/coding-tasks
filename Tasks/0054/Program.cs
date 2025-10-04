using System;
class program
{
    static void Main()
    {
        float fahrenheit = 450f;
        float celsius = (fahrenheit - 32f) / 1.8f;

        Console.WriteLine($"450 = {celsius:F2}");
    }
}