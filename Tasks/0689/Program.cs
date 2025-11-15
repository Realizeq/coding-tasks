using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();

        int nuli = 0;
        int edinici = 0;

        for (int i = 0; i < 50; i++)
        {
            int chislo = rand.Next(0, 2);
            if (chislo == 0)
            {
                nuli++;
            }
            else
            {
                edinici++;
            }
        }

        Console.WriteLine($"Нули {nuli}");
        Console.WriteLine($"Единицы {edinici}");
    }
}