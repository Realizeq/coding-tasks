using System;
class Program
{
    static void Main()
    {
        int[] moshnost = { 120, 150, 180, 210, 140, 170, 200, 230, 160, 190, 220, 130, 165, 195, 225, 135, 175, 205, 235, 125, 155, 185, 215, 145, 170, 195, 220, 140, 165, 190 };

        bool estBolshe200 = false;
        for (int i = 0; i < moshnost.Length; i++)
        {
            if (moshnost[i] > 200)
            {
                estBolshe200 = true;
                break;
            }
        }

        if (estBolshe200)
        {
            Console.WriteLine("Есть модели мощнее 200 лс");
        }
        else
        {
            Console.WriteLine("Нет моделей мощнее 200 лс");
        }
    }
}