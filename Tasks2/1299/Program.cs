using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("а) не (А или не В и С)");
        Console.WriteLine($"А=0, В=0, С=0: {!(false || !false && false)}");
        Console.WriteLine($"А=0, В=0, С=1: {!(false || !false && true)}");
        Console.WriteLine($"А=0, В=1, С=0: {!(false || !true && false)}");
        Console.WriteLine($"А=0, В=1, С=1: {!(false || !true && true)}");
        Console.WriteLine($"А=1, В=0, С=0: {!(true || !false && false)}");
        Console.WriteLine($"А=1, В=0, С=1: {!(true || !false && true)}");
        Console.WriteLine($"А=1, В=1, С=0: {!(true || !true && false)}");
        Console.WriteLine($"А=1, В=1, С=1: {!(true || !true && true)}");

        Console.WriteLine("б) А и не (В или не С)");
        Console.WriteLine($"А=0, В=0, С=0: {false && !(false || !false)}");
        Console.WriteLine($"А=0, В=0, С=1: {false && !(false || !true)}");
        Console.WriteLine($"А=0, В=1, С=0: {false && !(true || !false)}");
        Console.WriteLine($"А=0, В=1, С=1: {false && !(true || !true)}");
        Console.WriteLine($"А=1, В=0, С=0: {true && !(false || !false)}");
        Console.WriteLine($"А=1, В=0, С=1: {true && !(false || !true)}");
        Console.WriteLine($"А=1, В=1, С=0: {true && !(true || !false)}");
        Console.WriteLine($"А=1, В=1, С=1: {true && !(true || !true)}");

        Console.WriteLine("в) не (не А или В и С)");
        Console.WriteLine($"А=0, В=0, С=0: {!(!false || false && false)}");
        Console.WriteLine($"А=0, В=0, С=1: {!(!false || false && true)}");
        Console.WriteLine($"А=0, В=1, С=0: {!(!false || true && false)}");
        Console.WriteLine($"А=0, В=1, С=1: {!(!false || true && true)}");
        Console.WriteLine($"А=1, В=0, С=0: {!(!true || false && false)}");
        Console.WriteLine($"А=1, В=0, С=1: {!(!true || false && true)}");
        Console.WriteLine($"А=1, В=1, С=0: {!(!true || true && false)}");
        Console.WriteLine($"А=1, В=1, С=1: {!(!true || true && true)}");
    }
}