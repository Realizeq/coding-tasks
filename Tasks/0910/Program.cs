using System;
class Program
{
    static void Main()
    {
        int[] ocenki = { 5, 4, 3, 2, 5, 4, 3, 2, 5, 4, 3, 2, 5, 4, 3, 2, 5, 4, 3, 2, 5, 4, 3, 2, 5, 4, 3, 2 };

        bool estDvoyki = false;
        for (int i = 0; i < ocenki.Length; i++)
        {
            if (ocenki[i] == 2)
            {
                estDvoyki = true;
                break;
            }
        }

        if (estDvoyki)
        {
            Console.WriteLine("В классе есть двойки");
        }
        else
        {
            Console.WriteLine("В классе нет двоек");
        }
    }
}