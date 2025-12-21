using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("а) не А и не В или А");
        Console.WriteLine($"А = ложь, В = ложь: {(!false && !false) || false}");
        Console.WriteLine($"А = ложь, В = истина: {(!false && !true) || false}");
        Console.WriteLine($"А = истина, В = ложь: {(!true && !false) || true}");
        Console.WriteLine($"А = истина, В = истина: {(!true && !true) || true}");

        Console.WriteLine("б) В или не А и не В");
        Console.WriteLine($"А = ложь, В = ложь: {false || (!false && !false)}");
        Console.WriteLine($"А = ложь, В = истина: {true || (!false && !true)}");
        Console.WriteLine($"А = истина, В = ложь: {false || (!true && !false)}");
        Console.WriteLine($"А = истина, В = истина: {true || (!true && !true)}");

        Console.WriteLine("в) В и не (А и не В)");
        Console.WriteLine($"А = ложь, В = ложь: {false && !(false && !false)}");
        Console.WriteLine($"А = ложь, В = истина: {true && !(false && !true)}");
        Console.WriteLine($"А = истина, В = ложь: {false && !(true && !false)}");
        Console.WriteLine($"А = истина, В = истина: {true && !(true && !true)}");
    }
}