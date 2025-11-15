using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();

        for (int i = 0; i < 50; i++)
        {
            int chislo = rand.Next(0, 4);
            if (chislo == 0 || chislo == 1)
            {
                Console.WriteLine(chislo);
            }
        }
    }
}