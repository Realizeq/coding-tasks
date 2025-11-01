using System;
class Program
{
    static void Main()
    {
        int n = 5321;
        int temp = n;
        bool vozrastaet = true;
        int pred = temp % 10;
        temp /= 10;

        while (temp > 0)
        {
            int tek = temp % 10;
            if (tek <= pred)
            {
                vozrastaet = false;
                break;
            }
            pred = tek;
            temp /= 10;
        }

        if (vozrastaet) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
}