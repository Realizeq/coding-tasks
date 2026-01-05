using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("а) не (А или не В и С) или С");
        Console.WriteLine($"{!(false || !false && false) || false}");
        Console.WriteLine($"{!(false || !false && true) || true}");
        Console.WriteLine($"{!(false || !true && false) || false}");
        Console.WriteLine($"{!(false || !true && true) || true}");
        Console.WriteLine($"{!(true || !false && false) || false}");
        Console.WriteLine($"{!(true || !false && true) || true}");
        Console.WriteLine($"{!(true || !true && false) || false}");
        Console.WriteLine($"{!(true || !true && true) || true}");

        Console.WriteLine("б) не (А и не В или С) и В");
        Console.WriteLine($"{!(false && !false || false) && false}");
        Console.WriteLine($"{!(false && !false || true) && false}");
        Console.WriteLine($"{!(false && !true || false) && true}");
        Console.WriteLine($"{!(false && !true || true) && true}");
        Console.WriteLine($"{!(true && !false || false) && false}");
        Console.WriteLine($"{!(true && !false || true) && false}");
        Console.WriteLine($"{!(true && !true || false) && true}");
        Console.WriteLine($"{!(true && !true || true) && true}");

        Console.WriteLine("в) не (не А или В и С) или А");
        Console.WriteLine($"{!(!false || false && false) || false}");
        Console.WriteLine($"{!(!false || false && true) || false}");
        Console.WriteLine($"{!(!false || true && false) || false}");
        Console.WriteLine($"{!(!false || true && true) || false}");
        Console.WriteLine($"{!(!true || false && false) || true}");
        Console.WriteLine($"{!(!true || false && true) || true}");
        Console.WriteLine($"{!(!true || true && false) || true}");
        Console.WriteLine($"{!(!true || true && true) || true}");
    }
}