using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("а) не (не А и не В) и А");
        Console.WriteLine($"А = ложь, В = ложь: {!(!false && !false) && false}");
        Console.WriteLine($"А = ложь, В = истина: {!(!false && !true) && false}");
        Console.WriteLine($"А = истина, В = ложь: {!(!true && !false) && true}");
        Console.WriteLine($"А = истина, В = истина: {!(!true && !true) && true}");

        Console.WriteLine("б) не (не А или не В) или А");
        Console.WriteLine($"А = ложь, В = ложь: {!(!false || !false) || false}");
        Console.WriteLine($"А = ложь, В = истина: {!(!false || !true) || false}");
        Console.WriteLine($"А = истина, В = ложь: {!(!true || !false) || true}");
        Console.WriteLine($"А = истина, В = истина: {!(!true || !true) || true}");

        Console.WriteLine("в) не (не А или не В) и В");
        Console.WriteLine($"А = ложь, В = ложь: {!(!false || !false) && false}");
        Console.WriteLine($"А = ложь, В = истина: {!(!false || !true) && true}");
        Console.WriteLine($"А = истина, В = ложь: {!(!true || !false) && false}");
        Console.WriteLine($"А = истина, В = истина: {!(!true || !true) && true}");
    }
}