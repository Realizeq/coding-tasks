using System;
class Program
{
    static void Main()
    {
        for (int byki = 0; byki <= 10; byki++)
        {
            for (int korovy = 0; korovy <= 20; korovy++)
            {
                int telyata = 100 - byki - korovy;
                if (telyata >= 0)
                {
                    double summa = byki * 10 + korovy * 5 + telyata * 0.5;
                    if (summa == 100)
                    {
                        Console.WriteLine($"{byki} быков, {korovy} коров, {telyata} телят");
                    }
                }
            }
        }
    }
}