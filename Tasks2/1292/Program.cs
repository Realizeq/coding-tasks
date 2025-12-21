using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("а) не (X или Y)");
        Console.WriteLine($"X = ложь, Y = ложь: {!(false || false)}");
        Console.WriteLine($"X = ложь, Y = истина: {!(false || true)}");
        Console.WriteLine($"X = истина, Y = ложь: {!(true || false)}");
        Console.WriteLine($"X = истина, Y = истина: {!(true || true)}");

        Console.WriteLine("б) не X и Y");
        Console.WriteLine($"X = ложь, Y = ложь: {!false && false}");
        Console.WriteLine($"X = ложь, Y = истина: {!false && true}");
        Console.WriteLine($"X = истина, Y = ложь: {!true && false}");
        Console.WriteLine($"X = истина, Y = истина: {!true && true}");

        Console.WriteLine("в) X и не Y");
        Console.WriteLine($"X = ложь, Y = ложь: {false && !false}");
        Console.WriteLine($"X = ложь, Y = истина: {false && !true}");
        Console.WriteLine($"X = истина, Y = ложь: {true && !false}");
        Console.WriteLine($"X = истина, Y = истина: {true && !true}");
    }
}