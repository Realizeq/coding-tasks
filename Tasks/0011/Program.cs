Console.WriteLine("Введите название команды: ");
string teamName = Console.ReadLine();
if (string.IsNullOrWhiteSpace(teamName) || teamName.Any(char.IsDigit))
    Console.WriteLine("Введенное не является названием");
else
    Console.WriteLine($"{teamName} - это чемпион!");