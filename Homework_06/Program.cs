using System;

    internal class Program
{
    static void Main(string[] args)
    {
        int minutesInHour = 60;
        int timeOneHuman = 10;
        int allPeople;
        int allTimeHour;
        int allTimeMinute;

        Console.WriteLine($"Сколько человек стоит перед вами? Среднее время одного человека в очереди: {timeOneHuman} минут.");
        Console.WriteLine("Введите количество человек:");
        allPeople = Convert.ToInt32(Console.ReadLine());

        allTimeHour = allPeople * timeOneHuman / minutesInHour;
        allTimeMinute = allPeople * timeOneHuman % minutesInHour;

        Console.WriteLine($"Вам осталось ждать: {allTimeHour} час(а). {allTimeMinute} минут(ы).");
    }
}