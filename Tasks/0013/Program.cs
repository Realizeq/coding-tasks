Console.WriteLine("Введите целое число: ");
string input = Console.ReadLine();
if (int.TryParse(input, out int number))
{
    Console.WriteLine($"Следующее за числом {number}, число - {number + 1}");
    Console.WriteLine($"Для числа {number}, предыдущее число - {number - 1}");
}
else
    Console.WriteLine("Введено не целое число");