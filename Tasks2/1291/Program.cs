using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("а) не (А и В)");
        Console.WriteLine($"А = ложь, В = ложь: {!(false && false)}");
        Console.WriteLine($"А = ложь, В = истина: {!(false && true)}");
        Console.WriteLine($"А = истина, В = ложь: {!(true && false)}");
        Console.WriteLine($"А = истина, В = истина: {!(true && true)}");

        Console.WriteLine("б) не А или В");
        Console.WriteLine($"А = ложь, В = ложь: {!false || false}");
        Console.WriteLine($"А = ложь, В = истина: {!false || true}");
        Console.WriteLine($"А = истина, В = ложь: {!true || false}");
        Console.WriteLine($"А = истина, В = истина: {!true || true}");

        Console.WriteLine("в) А или не В");
        Console.WriteLine($"А = ложь, В = ложь: {false || !false}");
        Console.WriteLine($"А = ложь, В = истина: {false || !true}");
        Console.WriteLine($"А = истина, В = ложь: {true || !false}");
        Console.WriteLine($"А = истина, В = истина: {true || !true}");
    }
}