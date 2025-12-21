using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("а) не (X и не Y) или X");
        Console.WriteLine($"X = ложь, Y = ложь: {!(false && !false) || false}");
        Console.WriteLine($"X = ложь, Y = истина: {!(false && !true) || false}");
        Console.WriteLine($"X = истина, Y = ложь: {!(true && !false) || true}");
        Console.WriteLine($"X = истина, Y = истина: {!(true && !true) || true}");

        Console.WriteLine("б) Y и не X или не Y");
        Console.WriteLine($"X = ложь, Y = ложь: {(false && !false) || !false}");
        Console.WriteLine($"X = ложь, Y = истина: {(true && !false) || !true}");
        Console.WriteLine($"X = истина, Y = ложь: {(false && !true) || !false}");
        Console.WriteLine($"X = истина, Y = истина: {(true && !true) || !true}");

        Console.WriteLine("в) не Y и не X или Y");
        Console.WriteLine($"X = ложь, Y = ложь: {(!false && !false) || false}");
        Console.WriteLine($"X = ложь, Y = истина: {(!true && !false) || true}");
        Console.WriteLine($"X = истина, Y = ложь: {(!false && !true) || false}");
        Console.WriteLine($"X = истина, Y = истина: {(!true && !true) || true}");
    }
}