using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите последовательность слов: ");
        string text = Console.ReadLine();

        string correctedText = "";
        bool hasErrors = false;

        for (int i = 0; i < text.Length; i++)
        {
            correctedText += text[i];

            if (i < text.Length - 1)
            {
                if ((text[i] == 'ч' || text[i] == 'Ч') && (text[i + 1] == 'я' || text[i + 1] == 'Я'))
                {
                    Console.WriteLine($"Ошибка: 'чя' на позициях {i + 1}-{i + 2}, исправляем на 'ча'");
                    hasErrors = true;
                    correctedText = correctedText.Remove(correctedText.Length - 1, 1);
                    correctedText += text[i] == 'ч' ? 'а' : 'А';
                    i++;
                }
                else if ((text[i] == 'щ' || text[i] == 'Щ') && (text[i + 1] == 'я' || text[i + 1] == 'Я'))
                {
                    Console.WriteLine($"Ошибка: 'щя' на позициях {i + 1}-{i + 2}, исправляем на 'ща'");
                    hasErrors = true;
                    correctedText = correctedText.Remove(correctedText.Length - 1, 1);
                    correctedText += text[i] == 'щ' ? 'а' : 'А';
                    i++;
                }
            }
        }

        if (!hasErrors)
        {
            Console.WriteLine("Все буквосочетания правильные");
        }

        Console.WriteLine($"Исправленный текст: {correctedText}");
    }
}