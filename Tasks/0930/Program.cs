using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        BigInteger result = BigInteger.Pow(2, 100);
        string cifri = result.ToString();

        Console.WriteLine($"2^100 = {result}");
        Console.WriteLine($"Цифры: {cifri}");
    }
}