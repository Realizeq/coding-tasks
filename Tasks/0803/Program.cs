using System;
class Program
{
    static void Main()
    {
        int[] avto = { 25000, 30000, 35000, 28000, 32000 };
        int[] moto = { 8000, 12000, 9500, 11000, 7500 };

        int summaAvto = 0;
        for (int i = 0; i < avto.Length; i++)
        {
            summaAvto += avto[i];
        }
        double sredneeAvto = (double)summaAvto / avto.Length;

        int summaMoto = 0;
        for (int i = 0; i < moto.Length; i++)
        {
            summaMoto += moto[i];
        }
        double sredneeMoto = (double)summaMoto / moto.Length;

        if (sredneeAvto > sredneeMoto * 3)
        {
            Console.WriteLine("средняя стоимость авто превышает мото более чем в 3 раза");
        }
        else
        {
            Console.WriteLine("средняя стоимость авто не превышает мото более чем в 3 раза");
        }
    }
}