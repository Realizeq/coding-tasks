using System;
class Program
{
    static void Main()
    {
        string[] nomera = {"001М", "002С", "003А", "004В", "005Г",
                          "006Д", "007Е", "008Ж", "009З", "010И",
                          "011К", "012Л", "013М", "014Н", "015О",
                          "016П", "017Р", "018С", "019Т", "020У",
                          "021Ф", "022Х", "023Ц", "024Ч", "025Ш"};

        string[] naznacheniya = {"Москва-Омск", "СПб-Новосибирск", "Астана-Алматы", "Владивосток-Москва", "Гомель-Минск",
                                "Донецк-Ростов", "Екатеринбург-Челябинск", "Житомир-Киев", "Запорожье-Днепр", "Иркутск-Улан-Удэ",
                                "Краснодар-Сочи", "Львов-Киев", "Мурманск-Петрозаводск", "Нижний Новгород-Казань", "Орск-Оренбург",
                                "Пермь-Екатеринбург", "Рига-Вильнюс", "Самара-Уфа", "Тула-Москва", "Уфа-Челябинск",
                                "Фергана-Ташкент", "Харьков-Киев", "Цюрих-Берн", "Чита-Хабаровск", "Шымкент-Алматы"};

        int[] chasyPribytiya = {10, 14, 8, 22, 13, 9, 16, 11, 20, 15,
                               7, 18, 12, 17, 19, 6, 21, 23, 5, 4,
                               3, 2, 1, 0, 24};

        int[] minutyPribytiya = {30, 15, 45, 10, 20, 55, 5, 40, 25, 50,
                               35, 0, 10, 45, 30, 15, 40, 20, 55, 5,
                               50, 35, 25, 0, 30};

        int[] chasyOtpravleniya = {11, 15, 9, 23, 14, 10, 17, 12, 21, 16,
                                  8, 19, 13, 18, 20, 7, 22, 0, 6, 5,
                                  4, 3, 2, 1, 1};

        int[] minutyOtpravleniya = {15, 30, 0, 40, 5, 20, 50, 10, 45, 25,
                                  55, 15, 35, 0, 50, 40, 5, 30, 20, 55,
                                  10, 45, 35, 25, 15};

        Console.Write("Введите текущий час (0-23): ");
        int currentHour = int.Parse(Console.ReadLine());

        Console.Write("Введите текущую минуту (0-59): ");
        int currentMinute = int.Parse(Console.ReadLine());

        int currentTime = currentHour * 100 + currentMinute;

        Console.WriteLine("\nПоезда, стоящие на станции:");

        for (int i = 0; i < 25; i++)
        {
            int pribytie = chasyPribytiya[i] * 100 + minutyPribytiya[i];
            int otpravlenie = chasyOtpravleniya[i] * 100 + minutyOtpravleniya[i];

            if (otpravlenie < pribytie)
            {
                otpravlenie += 2400;
            }

            if (currentTime >= pribytie && currentTime < otpravlenie)
            {
                Console.WriteLine($"{nomera[i]} {naznacheniya[i]}, прибыл: {chasyPribytiya[i]:D2}:{minutyPribytiya[i]:D2}, отправляется: {chasyOtpravleniya[i]:D2}:{minutyOtpravleniya[i]:D2}");
            }
        }
    }
}