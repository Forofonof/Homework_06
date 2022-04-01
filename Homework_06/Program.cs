using System;

    internal class Program
{
    static void Main(string[] args)
    {
        int minutesInHour = 60;
        int timeOneHuman = 10;
        int allPeople;
        int hourOfWaiting;
        int minutesOfWaiting;

        Console.WriteLine($"Сколько человек стоит перед вами? Среднее время одного человека в очереди: {timeOneHuman} минут.");
        Console.WriteLine("Введите количество человек:");
        allPeople = Convert.ToInt32(Console.ReadLine());

        hourOfWaiting = allPeople * timeOneHuman / minutesInHour;
        minutesOfWaiting = allPeople * timeOneHuman % minutesInHour;

        Console.WriteLine($"Вам осталось ждать: {hourOfWaiting} час(а). {minutesOfWaiting} минут(ы).");
    }
}