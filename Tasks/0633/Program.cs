using System;
class Program
{
    static void Main()
    {
        int[,] zarplata = new int[12, 3];

        for (int rabotnik = 0; rabotnik < 12; rabotnik++)
        {
            Console.WriteLine($"Работник {rabotnik + 1}:");
            for (int mesyac = 0; mesyac < 3; mesyac++)
            {
                Console.Write($"Зарплата за месяц {mesyac + 1}: ");
                zarplata[rabotnik, mesyac] = int.Parse(Console.ReadLine());
            }
        }

        int obshayaSumma = 0;
        for (int rabotnik = 0; rabotnik < 12; rabotnik++)
        {
            for (int mesyac = 0; mesyac < 3; mesyac++)
            {
                obshayaSumma += zarplata[rabotnik, mesyac];
            }
        }
        Console.WriteLine($"Общая сумма за квартал: {obshayaSumma}");

        Console.WriteLine("Зарплата каждого работника за квартал:");
        for (int rabotnik = 0; rabotnik < 12; rabotnik++)
        {
            int summaRabotnika = 0;
            for (int mesyac = 0; mesyac < 3; mesyac++)
            {
                summaRabotnika += zarplata[rabotnik, mesyac];
            }
            Console.WriteLine($"Работник {rabotnik + 1}: {summaRabotnika}");
        }

        Console.WriteLine("Общая зарплата за каждый месяц:");
        for (int mesyac = 0; mesyac < 3; mesyac++)
        {
            int summaMesyaca = 0;
            for (int rabotnik = 0; rabotnik < 12; rabotnik++)
            {
                summaMesyaca += zarplata[rabotnik, mesyac];
            }
            Console.WriteLine($"Месяц {mesyac + 1}: {summaMesyaca}");
        }
    }
}