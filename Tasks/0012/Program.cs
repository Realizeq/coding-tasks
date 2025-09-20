Console.WriteLine("Введите имя: ");
string name = Console.ReadLine();
if (string.IsNullOrWhiteSpace(name) || name.Any(char.IsDigit))
    Console.WriteLine("Вы ввели не имя");
else
    Console.WriteLine($"Привет, {name}!");