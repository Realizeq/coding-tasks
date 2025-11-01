using System;
class Program
{
    static void Main()
    {
        int chislo = 12321;
        int original = chislo;

        int obratno = 0;
        while (chislo > 0)
        {
            int poslednyaya = chislo % 10;
            obratno = obratno * 10 + poslednyaya;
            chislo = chislo / 10;
        }

        if (original == obratno)
        {
            Console.WriteLine("палиндром");
        }
        else
        {
            Console.WriteLine("не палиндром");
        }
    }
}