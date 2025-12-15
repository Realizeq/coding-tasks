using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите первое предложение: ");
        string predlozhenie1 = Console.ReadLine();

        Console.Write("Введите второе предложение: ");
        string predlozhenie2 = Console.ReadLine();

        string[] words1 = predlozhenie1.Split(' ');
        string[] words2 = predlozhenie2.Split(' ');

        Console.Write("Результат: ");

        for (int i = 0; i < words1.Length; i++)
        {
            bool found = false;

            for (int j = 0; j < words2.Length; j++)
            {
                if (words1[i] == words2[j])
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.Write("да ");
            }
            else
            {
                Console.Write("нет ");
            }
        }
    }
}