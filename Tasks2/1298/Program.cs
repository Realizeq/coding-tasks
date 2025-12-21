using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("а) не (не X или Y) или не X");
        Console.WriteLine($"X = ложь, Y = ложь: {!(!false || false) || !false}");
        Console.WriteLine($"X = ложь, Y = истина: {!(!false || true) || !false}");
        Console.WriteLine($"X = истина, Y = ложь: {!(!true || false) || !true}");
        Console.WriteLine($"X = истина, Y = истина: {!(!true || true) || !true}");

        Console.WriteLine("б) не (не X и не Y) и X");
        Console.WriteLine($"X = ложь, Y = ложь: {!(!false && !false) && false}");
        Console.WriteLine($"X = ложь, Y = истина: {!(!false && !true) && false}");
        Console.WriteLine($"X = истина, Y = ложь: {!(!true && !false) && true}");
        Console.WriteLine($"X = истина, Y = истина: {!(!true && !true) && true}");

        Console.WriteLine("в) не (X или не Y) или не Y");
        Console.WriteLine($"X = ложь, Y = ложь: {!(false || !false) || !false}");
        Console.WriteLine($"X = ложь, Y = истина: {!(false || !true) || !true}");
        Console.WriteLine($"X = истина, Y = ложь: {!(true || !false) || !false}");
        Console.WriteLine($"X = истина, Y = истина: {!(true || !true) || !true}");
    }
}