using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("а) не X и не Y");
        Console.WriteLine($"X = ложь, Y = ложь: {!false && !false}");
        Console.WriteLine($"X = ложь, Y = истина: {!false && !true}");
        Console.WriteLine($"X = истина, Y = ложь: {!true && !false}");
        Console.WriteLine($"X = истина, Y = истина: {!true && !true}");

        Console.WriteLine("б) X или (не X и Y)");
        Console.WriteLine($"X = ложь, Y = ложь: {false || (!false && false)}");
        Console.WriteLine($"X = ложь, Y = истина: {false || (!false && true)}");
        Console.WriteLine($"X = истина, Y = ложь: {true || (!true && false)}");
        Console.WriteLine($"X = истина, Y = истина: {true || (!true && true)}");

        Console.WriteLine("в) (не X и Y) или Y");
        Console.WriteLine($"X = ложь, Y = ложь: {(!false && false) || false}");
        Console.WriteLine($"X = ложь, Y = истина: {(!false && true) || true}");
        Console.WriteLine($"X = истина, Y = ложь: {(!true && false) || false}");
        Console.WriteLine($"X = истина, Y = истина: {(!true && true) || true}");
    }
}