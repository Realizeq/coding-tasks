using System;
class Program
{
    static void Main()
    {
        for (int znamenatel = 2; znamenatel <= 7; znamenatel++)
        {
            for (int chislitel = 1; chislitel < znamenatel; chislitel++)
            {
                int a = chislitel;
                int b = znamenatel;

                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }

                if (a == 1)
                {
                    Console.WriteLine($"{chislitel}/{znamenatel}");
                }
            }
        }
    }
}