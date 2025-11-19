using System;
class Program
{
    static void Main()
    {
        double[] massiv = { 15.5, -8.2, 32.7, -12.1, 45.8, -3.9, 0, 27.4, -20.6, 10.9 };

        int polozhitelnye = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] > 0)
            {
                polozhitelnye++;
            }
        }

        if (polozhitelnye <= 5)
        {
            Console.WriteLine("положительных элементов не больше 5");
        }
        else
        {
            Console.WriteLine("положительных элементов больше 5");
        }

        int neBolshe50_55 = 0;
        for (int i = 0; i < massiv.Length; i++)
        {
            if (massiv[i] <= 50.55)
            {
                neBolshe50_55++;
            }
        }

        if (neBolshe50_55 % 4 == 0)
        {
            Console.WriteLine("количество элементов <=50.55 кратно 4");
        }
        else
        {
            Console.WriteLine("количество элементов <=50.55 не кратно 4");
        }
    }
}