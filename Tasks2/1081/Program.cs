using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово: ");
        string word = Console.ReadLine();

        int firstA = -1;
        int lastO = -1;

        for (int i = 0; i < word.Length; i++)
        {
            if ((word[i] == 'а' || word[i] == 'А') && firstA == -1)
            {
                firstA = i;
            }
            if (word[i] == 'о' || word[i] == 'О')
            {
                lastO = i;
            }
        }

        if (firstA != -1 && lastO != -1)
        {
            char[] chars = word.ToCharArray();

            char temp = chars[firstA];
            chars[firstA] = chars[lastO];
            chars[lastO] = temp;

            string result = new string(chars);
            Console.WriteLine($"Результат: {result}");
        }
        else
        {
            Console.WriteLine("Не найдены нужные буквы");
        }
    }
}