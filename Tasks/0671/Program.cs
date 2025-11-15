using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Трехзначные числа без одинаковых цифр:");

        for (int i = 100; i <= 999; i++)
        {
            int sotni = i / 100;
            int desyatki = (i / 10) % 10;
            int edinici = i % 10;

            if (sotni != desyatki && sotni != edinici && desyatki != edinici)
            {
                Console.WriteLine(i);
            }
        }
    }
}