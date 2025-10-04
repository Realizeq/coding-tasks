using System;
class program
{
    static void Main()
    {
        DateTime now = DateTime.Now;

        int fullHours = now.Hour;
        Console.WriteLine($"a) С начала суток прошло {fullHours} полных часов");

        int fullMinutes = now.Minute;
        Console.WriteLine($"б) С начала текущего часа прошло {fullMinutes} полных минут");

        int fullSeconds = now.Second;
        Console.WriteLine($"в) С начала текущей минуты прошло {fullSeconds} полных секунд");
    }
}