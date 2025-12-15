using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите число от 1 до 1000: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 1 || n > 1000)
        {
            Console.WriteLine("Число должно быть от 1 до 1000");
            return;
        }

        if (n == 1000)
        {
            Console.WriteLine("тысяча");
            return;
        }

        string[] units = { " ", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
        string[] teens = {"десять", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать",
                         "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать"};
        string[] tens = {"", "", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят",
                        "семьдесят", "восемьдесят", "девяносто"};
        string[] hundreds = {"", "сто", "двести", "триста", "четыреста", "пятьсот",
                           "шестьсот", "семьсот", "восемьсот", "девятьсот"};

        string result = " ";

        int hundredsDigit = n / 100;
        int tensDigit = (n / 10) % 10;
        int unitsDigit = n % 10;

        if (hundredsDigit > 0)
        {
            result += hundreds[hundredsDigit] + " ";
        }

        if (tensDigit == 1)
        {
            result += teens[unitsDigit] + " ";
        }
        else
        {
            if (tensDigit > 1)
            {
                result += tens[tensDigit] + " ";
            }

            if (unitsDigit > 0)
            {
                result += units[unitsDigit];
            }
        }

        Console.WriteLine(result.Trim());
    }
}