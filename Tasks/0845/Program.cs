using System;
class Program
{
    static void Main()
    {
        int[] ochki = { 1, 1, 0, 3, 1, 0, 3, 1, 0, 3 };

        int indexPobeda = -1;
        int indexPorazhenie = -1;

        for (int i = 0; i < ochki.Length; i++)
        {
            if (ochki[i] == 3 && indexPobeda == -1)
            {
                indexPobeda = i;
            }
            if (ochki[i] == 0 && indexPorazhenie == -1)
            {
                indexPorazhenie = i;
            }
        }

        if (indexPobeda < indexPorazhenie)
        {
            Console.WriteLine("Раньше был первый выигрыш");
        }
        else if (indexPorazhenie < indexPobeda)
        {
            Console.WriteLine("Раньше был первый проигрыш");
        }
        else
        {
            Console.WriteLine("Выигрыш и проигрыш в одной игре");
        }
    }
}