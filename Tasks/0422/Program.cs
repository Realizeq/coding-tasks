using System;
class Program
{
    static void Main()
    {
        int n = 666;
        int temp = n;
        int last = temp % 10;
        bool odinakovie = true;

        while (temp > 0)
        {
            if (temp % 10 != last)
            {
                odinakovie = false;
                break;
            }
            temp /= 10;
        }

        if (odinakovie) Console.WriteLine("а) да");
        else Console.WriteLine("а) нет");

        n = 35510;
        temp = n;
        bool ryadom = false;
        int pred = temp % 10;
        temp /= 10;

        while (temp > 0)
        {
            int tek = temp % 10;
            if (tek == pred)
            {
                ryadom = true;
                break;
            }
            pred = tek;
            temp /= 10;
        }

        if (ryadom) Console.WriteLine("б) да");
        else Console.WriteLine("б) нет");
    }
}