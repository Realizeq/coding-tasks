using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();
        int[] massiv = new int[20];

        for (int i = 0; i < 20; i++)
        {
            int novoeChislo;
            bool povtoryaetsya;

            do
            {
                povtoryaetsya = false;
                novoeChislo = rand.Next(1, 101);

                for (int j = 0; j < i; j++)
                {
                    if (massiv[j] == novoeChislo)
                    {
                        povtoryaetsya = true;
                        break;
                    }
                }
            }
            while (povtoryaetsya);

            massiv[i] = novoeChislo;
        }

        Console.WriteLine("Массив с неповторяющимися числами:");
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine($"[{i}] = {massiv[i]}");
        }
    }
}