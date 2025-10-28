using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        int number = int.Parse(Console.ReadLine());

        int sum = 0;
        int count = 0;
        int product = 1;
        int sumSquares = 0;
        int sumCubes = 0;
        int firstDigit = 0;
        int lastDigit = number % 10;

        int temp = number;
        while (temp > 0)
        {
            int digit = temp % 10;

            sum += digit;
            count++;
            product *= digit;
            sumSquares += digit * digit;
            sumCubes += digit * digit * digit;
            firstDigit = digit;

            temp /= 10;
        }

        float average = (float)sum / count;

        int sumFirstLast = firstDigit + lastDigit;

        Console.WriteLine($"а) {sum}");
        Console.WriteLine($"б) {count}");
        Console.WriteLine($"в) {product}");
        Console.WriteLine($"г) {average:f2}");
        Console.WriteLine($"д) {sumSquares}");
        Console.WriteLine($"е) {sumCubes}");
        Console.WriteLine($"ж) {firstDigit}");
        Console.WriteLine($"з) {sumFirstLast}");
    }
}