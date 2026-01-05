using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("а) не (X или Y) и (не X или не Z)");
        Console.WriteLine($"{!(false || false) && (!false || !false)}");
        Console.WriteLine($"{!(false || false) && (!false || !true)}");
        Console.WriteLine($"{!(false || true) && (!false || !false)}");
        Console.WriteLine($"{!(false || true) && (!false || !true)}");
        Console.WriteLine($"{!(true || false) && (!true || !false)}");
        Console.WriteLine($"{!(true || false) && (!true || !true)}");
        Console.WriteLine($"{!(true || true) && (!true || !false)}");
        Console.WriteLine($"{!(true || true) && (!true || !true)}");

        Console.WriteLine("б) не (не X и Y) или (X и не Z)");
        Console.WriteLine($"{!(!false && false) || (false && !false)}");
        Console.WriteLine($"{!(!false && false) || (false && !true)}");
        Console.WriteLine($"{!(!false && true) || (false && !false)}");
        Console.WriteLine($"{!(!false && true) || (false && !true)}");
        Console.WriteLine($"{!(!true && false) || (true && !false)}");
        Console.WriteLine($"{!(!true && false) || (true && !true)}");
        Console.WriteLine($"{!(!true && true) || (true && !false)}");
        Console.WriteLine($"{!(!true && true) || (true && !true)}");

        Console.WriteLine("в) X или не Y и не (X или не Z)");
        Console.WriteLine($"{false || !false && !(false || !false)}");
        Console.WriteLine($"{false || !false && !(false || !true)}");
        Console.WriteLine($"{false || !true && !(false || !false)}");
        Console.WriteLine($"{false || !true && !(false || !true)}");
        Console.WriteLine($"{true || !false && !(true || !false)}");
        Console.WriteLine($"{true || !false && !(true || !true)}");
        Console.WriteLine($"{true || !true && !(true || !false)}");
        Console.WriteLine($"{true || !true && !(true || !true)}");
    }
}