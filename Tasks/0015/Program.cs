Console.WriteLine("Введите через пробел любые четыре числа");
string[] numbers = Console.ReadLine().Split(' ');
Console.WriteLine($"{numbers[0]}{numbers[1]} {numbers[2]}{numbers[3]}");