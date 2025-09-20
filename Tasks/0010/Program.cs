Console.WriteLine("Введите ваше имя: ");
string name = Console.ReadLine();
if (string.IsNullOrWhiteSpace(name) || name.Any(char.IsDigit))
    Console.WriteLine("Введено не имя");
else
    Console.WriteLine(name);