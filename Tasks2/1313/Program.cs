using System;
class Program
{
    static void Main()
    {
        int a = 1, b = 1, c = 8, d = 8, e = 2, f = 2;

        bool bLadya = a == e || b == f;
        bool bSlon = Math.Abs(a - e) == Math.Abs(b - f);
        bool bKon = (Math.Abs(a - e) == 2 && Math.Abs(b - f) == 1) || (Math.Abs(a - e) == 1 && Math.Abs(b - f) == 2);
        bool bFerz = bLadya || bSlon;
        bool bKorol = Math.Abs(a - e) <= 1 && Math.Abs(b - f) <= 1;

        bool cLadya = c == e || d == f;
        bool cSlon = Math.Abs(c - e) == Math.Abs(d - f);
        bool cKon = (Math.Abs(c - e) == 2 && Math.Abs(d - f) == 1) || (Math.Abs(c - e) == 1 && Math.Abs(d - f) == 2);
        bool cFerz = cLadya || cSlon;
        bool cKorol = Math.Abs(c - e) <= 1 && Math.Abs(d - f) <= 1;

        bool a1 = bLadya && !cLadya;
        bool a2 = bLadya && !cFerz;
        bool a3 = bLadya && !cKon;
        bool a4 = bLadya && !cSlon;
        bool a5 = bFerz && !cFerz;
        bool a6 = bFerz && !cLadya;
        bool a7 = bFerz && !cKon;
        bool a8 = bFerz && !cSlon;
        bool a9 = bKon && !cKon;
        bool a10 = bKon && !cLadya;
        bool a11 = bKon && !cFerz;
        bool a12 = bKon && !cSlon;
        bool a13 = bSlon && !cSlon;
        bool a14 = bSlon && !cFerz;
        bool a15 = bSlon && !cKon;
        bool a16 = bSlon && !cLadya;
        bool a17 = bKorol && !cSlon;
        bool a18 = bKorol && !cFerz;
        bool a19 = bKorol && !cKon;
        bool a20 = bKorol && !cLadya;

        Console.WriteLine($"а) {a1}");
        Console.WriteLine($"б) {a2}");
        Console.WriteLine($"в) {a3}");
        Console.WriteLine($"г) {a4}");
        Console.WriteLine($"д) {a5}");
        Console.WriteLine($"е) {a6}");
        Console.WriteLine($"ж) {a7}");
        Console.WriteLine($"з) {a8}");
        Console.WriteLine($"и) {a9}");
        Console.WriteLine($"к) {a10}");
        Console.WriteLine($"л) {a11}");
        Console.WriteLine($"м) {a12}");
        Console.WriteLine($"н) {a13}");
        Console.WriteLine($"о) {a14}");
        Console.WriteLine($"п) {a15}");
        Console.WriteLine($"р) {a16}");
        Console.WriteLine($"с) {a17}");
        Console.WriteLine($"т) {a18}");
        Console.WriteLine($"у) {a19}");
        Console.WriteLine($"ф) {a20}");
    }
}