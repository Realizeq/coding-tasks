using System;
class Program
{
    static void Main()
    {
        int[] osadki = { 5, 0, 3, 7, 2, 0, 4, 1, 6, 0, 8, 3, 0, 2, 5, 0, 1, 4, 7, 0, 3, 6, 2, 0, 5, 1, 0, 4, 2, 3 };

        int pervayaPolovina = 0;
        int vtorayaPolovina = 0;

        for (int i = 0; i < 15; i++)
        {
            pervayaPolovina += osadki[i];
        }

        for (int i = 15; i < 30; i++)
        {
            vtorayaPolovina += osadki[i];
        }

        if (pervayaPolovina > vtorayaPolovina)
        {
            Console.WriteLine("Больше осадков выпало в первую половину");
        }
        else if (vtorayaPolovina > pervayaPolovina)
        {
            Console.WriteLine("Больше осадков выпало во вторую половину");
        }
        else
        {
            Console.WriteLine("Осадков выпало одинаково");
        }

        int pervayaDecada = 0;
        int vtorayaDecada = 0;
        int tretiyaDecada = 0;

        for (int i = 0; i < 10; i++)
        {
            pervayaDecada += osadki[i];
        }

        for (int i = 10; i < 20; i++)
        {
            vtorayaDecada += osadki[i];
        }

        for (int i = 20; i < 30; i++)
        {
            tretiyaDecada += osadki[i];
        }

        if (pervayaDecada > vtorayaDecada && pervayaDecada > tretiyaDecada)
        {
            Console.WriteLine("Больше всего осадков в первую декаду");
        }
        else if (vtorayaDecada > pervayaDecada && vtorayaDecada > tretiyaDecada)
        {
            Console.WriteLine("Больше всего осадков во вторую декаду");
        }
        else if (tretiyaDecada > pervayaDecada && tretiyaDecada > vtorayaDecada)
        {
            Console.WriteLine("Больше всего осадков в третью декаду");
        }
        else
        {
            Console.WriteLine("Осадков выпало одинаково в несколько декад");
        }
    }
}