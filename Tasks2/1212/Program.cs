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

        string novayaFamiliya = "Фомин";
        float rostNovogo = 177;

        string[] novyeFamilii = new string[16];
        float[] novyeRost = new float[16];

        int i = 0;
        while (i < 15 && rost[i] > rostNovogo)
        {
            novyeFamilii[i] = familii[i];
            novyeRost[i] = rost[i];
            i++;
        }

        novyeFamilii[i] = novayaFamiliya;
        novyeRost[i] = rostNovogo;

        while (i < 15)
        {
            novyeFamilii[i + 1] = familii[i];
            novyeRost[i + 1] = rost[i];
            i++;
        }

        Console.WriteLine("Новый список учеников по убыванию роста:");
        for (int j = 0; j < 16; j++)
        {
            Console.WriteLine($"{novyeFamilii[j]} - {novyeRost[j]} см");
        }
    }
}