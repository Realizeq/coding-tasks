using System;
class Program
{
    static void Main()
    {
        int n = 9663;
        int temp = n;
        bool neubivaet = true;
        int pred = temp % 10;
        temp /= 10;

        while (temp > 0)
        {
            int tek = temp % 10;
            if (tek < pred)
            {
                neubivaet = false;
                break;
            }
            pred = tek;
            temp /= 10;
        }

        if (neubivaet) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
}