using System;
class Program
{
    static void Main()
    {
        int count = 0;
        int chislo = 2;

        while (count < 100)
        {
            bool prostoe = true;

            for (int i = 2; i < chislo; i++)
            {
                if (chislo % i == 0)
                {
                    prostoe = false;
                    break;
                }
            }

            if (prostoe)
            {
                Console.WriteLine(chislo);
                count++;
            }

            chislo++;
        }
    }
}