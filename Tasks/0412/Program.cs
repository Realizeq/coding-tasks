using System;
class Program
{
    static void Main()
    {
        int a = 12;
        int b = 18;

        int num1 = a;
        int num2 = b;

        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        int nod = a;
        int nok = num1 * num2 / nod;

        Console.WriteLine($"наименьшее общее кратное чисел {num1} и {num2} = {nok}");
    }
}