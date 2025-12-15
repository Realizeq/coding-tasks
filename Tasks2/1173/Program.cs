using System;
class Program
{
    static void Main()
    {
        string[] familii = {"Иванов", "Петров", "Сидорова", "Кузнецов", "Смирнова",
                           "Васильев", "Попова", "Соколов", "Михайлова", "Новиков",
                           "Федорова", "Морозов", "Волкова", "Алексеев", "Лебедева",
                           "Семенов", "Егорова", "Павлов", "Козлова", "Степанов",
                           "Николаев", "Орлова", "Андреев", "Макарова", "Никитин"};

        bool[] zhenaty = {true, false, true, true, true,
                         false, true, false, true, true,
                         true, false, true, true, true,
                         false, true, true, true, false,
                         true, true, false, true, true};

        bool[] deti = {true, false, true, false, true,
                      false, true, true, false, true,
                      false, true, true, true, false,
                      true, false, true, false, true,
                      true, false, true, true, false};

        Console.WriteLine("Женатые/замужние люди с детьми:");
        for (int i = 0; i < 25; i++)
        {
            if (zhenaty[i] && deti[i])
            {
                Console.WriteLine(familii[i]);
            }
        }
    }
}