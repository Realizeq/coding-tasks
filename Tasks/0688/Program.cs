using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();

        for (int i = 0; i < 30; i++)
        {
            int chislo = rand.Next(0, 6);
            if (chislo % 2 != 0)
            {
                Console.WriteLine(chislo);
            }
        }
    }
}