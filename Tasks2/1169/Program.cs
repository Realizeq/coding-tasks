using System;
class Program
{
    static void Main()
    {
        string[] familii = {"Иванов", "Петров", "Сидоров", "Кузнецов", "Смирнов",
                           "Васильев", "Попов", "Соколов", "Михайлов", "Новиков",
                           "Федоров", "Морозов", "Волков", "Алексеев", "Лебедев", "Егоров"};

        bool[] voennoobyazanny = {true, false, true, true, false,
                                 false, true, false, true, true,
                                 false, true, false, true, false, true};

        Console.WriteLine("Военнообязанные сотрудники:");
        for (int i = 0; i < 16; i++)
        {
            if (voennoobyazanny[i])
            {
                Console.WriteLine(familii[i]);
            }
        }
    }
}