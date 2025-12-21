using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("а) не А или не В");
        Console.WriteLine($"А = ложь, В = ложь: {!false || !false}");
        Console.WriteLine($"А = ложь, В = истина: {!false || !true}");
        Console.WriteLine($"А = истина, В = ложь: {!true || !false}");
        Console.WriteLine($"А = истина, В = истина: {!true || !true}");

        Console.WriteLine("б) А и (А или не В)");
        Console.WriteLine($"А = ложь, В = ложь: {false && (false || !false)}");
        Console.WriteLine($"А = ложь, В = истина: {false && (false || !true)}");
        Console.WriteLine($"А = истина, В = ложь: {true && (true || !false)}");
        Console.WriteLine($"А = истина, В = истина: {true && (true || !true)}");

        Console.WriteLine("в) (не А или В) и В");
        Console.WriteLine($"А = ложь, В = ложь: {(!false || false) && false}");
        Console.WriteLine($"А = ложь, В = истина: {(!false || true) && true}");
        Console.WriteLine($"А = истина, В = ложь: {(!true || false) && false}");
        Console.WriteLine($"А = истина, В = истина: {(!true || true) && true}");
    }
}