using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("а) не (X или не Y и Z)");
        Console.WriteLine($"X=0, Y=0, Z=0: {!(false || !false && false)}");
        Console.WriteLine($"X=0, Y=0, Z=1: {!(false || !false && true)}");
        Console.WriteLine($"X=0, Y=1, Z=0: {!(false || !true && false)}");
        Console.WriteLine($"X=0, Y=1, Z=1: {!(false || !true && true)}");
        Console.WriteLine($"X=1, Y=0, Z=0: {!(true || !false && false)}");
        Console.WriteLine($"X=1, Y=0, Z=1: {!(true || !false && true)}");
        Console.WriteLine($"X=1, Y=1, Z=0: {!(true || !true && false)}");
        Console.WriteLine($"X=1, Y=1, Z=1: {!(true || !true && true)}");

        Console.WriteLine("б) Y или (X и не Y или Z)");
        Console.WriteLine($"X=0, Y=0, Z=0: {false || (false && !false || false)}");
        Console.WriteLine($"X=0, Y=0, Z=1: {false || (false && !false || true)}");
        Console.WriteLine($"X=0, Y=1, Z=0: {true || (false && !true || false)}");
        Console.WriteLine($"X=0, Y=1, Z=1: {true || (false && !true || true)}");
        Console.WriteLine($"X=1, Y=0, Z=0: {false || (true && !false || false)}");
        Console.WriteLine($"X=1, Y=0, Z=1: {false || (true && !false || true)}");
        Console.WriteLine($"X=1, Y=1, Z=0: {true || (true && !true || false)}");
        Console.WriteLine($"X=1, Y=1, Z=1: {true || (true && !true || true)}");

        Console.WriteLine("в) не (не X и Y или Z)");
        Console.WriteLine($"X=0, Y=0, Z=0: {!(!false && false || false)}");
        Console.WriteLine($"X=0, Y=0, Z=1: {!(!false && false || true)}");
        Console.WriteLine($"X=0, Y=1, Z=0: {!(!false && true || false)}");
        Console.WriteLine($"X=0, Y=1, Z=1: {!(!false && true || true)}");
        Console.WriteLine($"X=1, Y=0, Z=0: {!(!true && false || false)}");
        Console.WriteLine($"X=1, Y=0, Z=1: {!(!true && false || true)}");
        Console.WriteLine($"X=1, Y=1, Z=0: {!(!true && true || false)}");
        Console.WriteLine($"X=1, Y=1, Z=1: {!(!true && true || true)}");
    }
}