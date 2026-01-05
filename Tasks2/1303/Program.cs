using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("а) не (А и В) и (не А или не С)");
        Console.WriteLine($"{!(false && false) && (!false || !false)}");
        Console.WriteLine($"{!(false && false) && (!false || !true)}");
        Console.WriteLine($"{!(false && true) && (!false || !false)}");
        Console.WriteLine($"{!(false && true) && (!false || !true)}");
        Console.WriteLine($"{!(true && false) && (!true || !false)}");
        Console.WriteLine($"{!(true && false) && (!true || !true)}");
        Console.WriteLine($"{!(true && true) && (!true || !false)}");
        Console.WriteLine($"{!(true && true) && (!true || !true)}");

        Console.WriteLine("б) не (А и не В) или (А или не С)");
        Console.WriteLine($"{!(false && !false) || (false || !false)}");
        Console.WriteLine($"{!(false && !false) || (false || !true)}");
        Console.WriteLine($"{!(false && !true) || (false || !false)}");
        Console.WriteLine($"{!(false && !true) || (false || !true)}");
        Console.WriteLine($"{!(true && !false) || (true || !false)}");
        Console.WriteLine($"{!(true && !false) || (true || !true)}");
        Console.WriteLine($"{!(true && !true) || (true || !false)}");
        Console.WriteLine($"{!(true && !true) || (true || !true)}");

        Console.WriteLine("в) А и не В или не (А или не С)");
        Console.WriteLine($"{false && !false || !(false || !false)}");
        Console.WriteLine($"{false && !false || !(false || !true)}");
        Console.WriteLine($"{false && !true || !(false || !false)}");
        Console.WriteLine($"{false && !true || !(false || !true)}");
        Console.WriteLine($"{true && !false || !(true || !false)}");
        Console.WriteLine($"{true && !false || !(true || !true)}");
        Console.WriteLine($"{true && !true || !(true || !false)}");
        Console.WriteLine($"{true && !true || !(true || !true)}");
    }
}