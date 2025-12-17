using System;
class Program
{
    static void Main()
    {
        string[] familii = {"Иванов", "Петров", "Сидоров", "Кузнецов", "Смирнов",
                           "Васильев", "Попов", "Соколов", "Михайлов", "Новиков",
                           "Федоров", "Морозов", "Волков", "Алексеев", "Лебедев", "Егоров"};

        int[] vozrast = {25, 30, 35, 40, 28, 32, 45, 38, 27, 33,
                        29, 31, 36, 42, 26, 34};

        bool[] voennoobyazanny = {true, false, true, true, false,
                                 false, true, false, true, true,
                                 false, true, false, true, false, true};

        int minVozrastVoenniy = int.MaxValue;
        int maxVozrastVoenniy = 0;
        int maxVozrastNevoenniy = 0;
        int indexMinVoenniy = -1;
        int indexMaxVoenniy = -1;
        int indexMaxNevoenniy = -1;

        for (int i = 0; i < 16; i++)
        {
            if (voennoobyazanny[i])
            {
                if (vozrast[i] < minVozrastVoenniy)
                {
                    minVozrastVoenniy = vozrast[i];
                    indexMinVoenniy = i;
                }

                if (vozrast[i] > maxVozrastVoenniy)
                {
                    maxVozrastVoenniy = vozrast[i];
                    indexMaxVoenniy = i;
                }
            }
            else
            {
                if (vozrast[i] > maxVozrastNevoenniy)
                {
                    maxVozrastNevoenniy = vozrast[i];
                    indexMaxNevoenniy = i;
                }
            }
        }

        Console.WriteLine($"а) Самый младший военнообязанный: {familii[indexMinVoenniy]} - {vozrast[indexMinVoenniy]} лет");

        Console.WriteLine($"б) Самый старший военнообязанный: {familii[indexMaxVoenniy]} - {vozrast[indexMaxVoenniy]} лет");
        Console.WriteLine($"Самый старший невоеннообязанный: {familii[indexMaxNevoenniy]} - {vozrast[indexMaxNevoenniy]} лет");
    }
}