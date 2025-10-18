using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите трехзначное число: ");
        int number = int.Parse(Console.ReadLine());

        int firstDigit = number / 100;
        int secondDigit = (number / 10) % 10;
        int thirdDigit = number % 10;

        string CompareDigits(int digit1, int digit2, string name1, string name2)
        {
            if (digit1 > digit2)
                return name1;
            else if (digit2 > digit1)
                return name2;
            else
                return "равны";
        }

        string resultA = CompareDigits(firstDigit, thirdDigit, "первая", "последняя");
        string resultB = CompareDigits(firstDigit, secondDigit, "первая", "вторая");
        string resultC = CompareDigits(secondDigit, thirdDigit, "вторая", "последняя");

        Console.WriteLine($"а) Какая цифра больше (первая или последняя) - {resultA}");
        Console.WriteLine($"б) Какая цифра больше (первая или вторая) - {resultB}");
        Console.WriteLine($"в) Какая цифра больше (вторая или последняя) - {resultC}");
    }
}