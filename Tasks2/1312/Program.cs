using System;
class Program
{
    static void Main()
    {
        int a = 1, b = 1, c = 2, d = 2;

        bool ladya = a == c || b == d;
        bool slon = Math.Abs(a - c) == Math.Abs(b - d);
        bool korol = Math.Abs(a - c) <= 1 && Math.Abs(b - d) <= 1;
        bool ferz = ladya || slon;
        bool belPeshObyc = c == a && d == b + 1;
        bool belPeshBeat = Math.Abs(a - c) == 1 && d == b + 1;
        bool chernPeshObyc = c == a && d == b - 1;
        bool chernPeshBeat = Math.Abs(a - c) == 1 && d == b - 1;
        bool kon = (Math.Abs(a - c) == 2 && Math.Abs(b - d) == 1) || (Math.Abs(a - c) == 1 && Math.Abs(b - d) == 2);

        Console.WriteLine($"а) {ladya}");
        Console.WriteLine($"б) {slon}");
        Console.WriteLine($"в) {korol}");
        Console.WriteLine($"г) {ferz}");
        Console.WriteLine($"д обычный: {belPeshObyc}");
        Console.WriteLine($"д бьет: {belPeshBeat}");
        Console.WriteLine($"е обычный: {chernPeshObyc}");
        Console.WriteLine($"е бьет: {chernPeshBeat}");
        Console.WriteLine($"ж) {kon}");
    }
}