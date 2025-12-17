using System;
class Program
{
    static void Main()
    {
        string[] familii = {"Петров", "Иванов", "Сидоров", "Кузнецов", "Смирнов",
                           "Васильев", "Попов", "Соколов", "Михайлов", "Новиков",
                           "Федоров", "Морозов", "Волков", "Алексеев", "Лебедев"};

        float[] rost = {190, 188, 185, 183, 182,
                       180, 178, 176, 175, 174,
                       173, 172, 171, 170, 168};

        float rostNovogo = 177;

        Console.WriteLine("а) Ученики с ростом меньше нового ученика:");
        int i = 0;
        while (i < 15 && rost[i] > rostNovogo)
        {
            i++;
        }
        while (i < 15)
        {
            Console.WriteLine($"{familii[i]} - {rost[i]} см");
            i++;
        }

        Console.WriteLine("\nб) После кого следует записать нового ученика:");
        i = 0;
        while (i < 15 && rost[i] > rostNovogo)
        {
            i++;
        }
        if (i > 0)
        {
            Console.WriteLine($"После ученика {familii[i - 1]} ({rost[i - 1]} см)");
        }
        else
        {
            Console.WriteLine("В начало списка");
        }

        Console.WriteLine("\nв) Ученик, рост которого меньше всего отличается:");
        float minRaznica = float.MaxValue;
        int indexMinRaznica = -1;

        for (i = 0; i < 15; i++)
        {
            float raznica = Math.Abs(rost[i] - rostNovogo);
            if (raznica < minRaznica)
            {
                minRaznica = raznica;
                indexMinRaznica = i;
            }
        }

        Console.WriteLine($"{familii[indexMinRaznica]} - разница {minRaznica} см");
    }
}