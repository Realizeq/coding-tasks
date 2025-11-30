using System;
class Program
{
    static void Main()
    {
        int[] cifri = new int[300];
        cifri[0] = 1;
        int len = 1;

        for (int n = 2; n <= 100; n++)
        {
            int carry = 0;
            for (int i = 0; i < len; i++)
            {
                int product = cifri[i] * n + carry;
                cifri[i] = product % 10;
                carry = product / 10;
            }

            while (carry > 0)
            {
                cifri[len] = carry % 10;
                carry = carry / 10;
                len++;
            }
        }

        Console.Write("100! = ");
        for (int i = len - 1; i >= 0; i--)
        {
            Console.Write(cifri[i]);
        }
    }
}