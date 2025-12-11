using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите последовательность слов: ");
        string text = Console.ReadLine();

        bool correct = true;

        for (int i = 0; i < text.Length - 1; i++)
        {
            if ((text[i] == 'ж' || text[i] == 'Ж') && (text[i + 1] == 'ы' || text[i + 1] == 'Ы'))
            {
                Console.WriteLine($"Ошибка: 'жы' на позициях {i + 1}-{i + 2}");
                correct = false;
            }
            if ((text[i] == 'ш' || text[i] == 'Ш') && (text[i + 1] == 'ы' || text[i + 1] == 'Ы'))
            {
                Console.WriteLine($"Ошибка: 'шы' на позициях {i + 1}-{i + 2}");
                correct = false;
            }
            if ((text[i] == 'ч' || text[i] == 'Ч') && (text[i + 1] == 'ю' || text[i + 1] == 'Ю'))
            {
                Console.WriteLine($"Ошибка: 'чю' на позициях {i + 1}-{i + 2}");
                correct = false;
            }
            if ((text[i] == 'щ' || text[i] == 'Щ') && (text[i + 1] == 'ю' || text[i + 1] == 'Ю'))
            {
                Console.WriteLine($"Ошибка: 'щю' на позициях {i + 1}-{i + 2}");
                correct = false;
            }
            if ((text[i] == 'ч' || text[i] == 'Ч') && (text[i + 1] == 'я' || text[i + 1] == 'Я'))
            {
                Console.WriteLine($"Ошибка: 'чя' на позициях {i + 1}-{i + 2}");
                correct = false;
            }
            if ((text[i] == 'щ' || text[i] == 'Щ') && (text[i + 1] == 'я' || text[i + 1] == 'Я'))
            {
                Console.WriteLine($"Ошибка: 'щя' на позициях {i + 1}-{i + 2}");
                correct = false;
            }
        }

        if (correct)
        {
            Console.WriteLine("Все буквосочетания правильные");
        }
    }
}