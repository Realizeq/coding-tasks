using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("а) не (Y или не X и Z) или Z");
        Console.WriteLine($"{!(false || !false && false) || false}");
        Console.WriteLine($"{!(false || !false && true) || true}");
        Console.WriteLine($"{!(true || !false && false) || false}");
        Console.WriteLine($"{!(true || !false && true) || true}");
        Console.WriteLine($"{!(false || !true && false) || false}");
        Console.WriteLine($"{!(false || !true && true) || true}");
        Console.WriteLine($"{!(true || !true && false) || false}");
        Console.WriteLine($"{!(true || !true && true) || true}");

        Console.WriteLine("б) X и не (не Y или Z) или Y");
        Console.WriteLine($"{false && !(!false || false) || false}");
        Console.WriteLine($"{false && !(!false || true) || false}");
        Console.WriteLine($"{false && !(!true || false) || true}");
        Console.WriteLine($"{false && !(!true || true) || true}");
        Console.WriteLine($"{true && !(!false || false) || false}");
        Console.WriteLine($"{true && !(!false || true) || false}");
        Console.WriteLine($"{true && !(!true || false) || true}");
        Console.WriteLine($"{true && !(!true || true) || true}");

        Console.WriteLine("в) не (X или Y и Z) или не X");
        Console.WriteLine($"{!(false || false && false) || !false}");
        Console.WriteLine($"{!(false || false && true) || !false}");
        Console.WriteLine($"{!(false || true && false) || !false}");
        Console.WriteLine($"{!(false || true && true) || !false}");
        Console.WriteLine($"{!(true || false && false) || !true}");
        Console.WriteLine($"{!(true || false && true) || !true}");
        Console.WriteLine($"{!(true || true && false) || !true}");
        Console.WriteLine($"{!(true || true && true) || !true}");
    }
}