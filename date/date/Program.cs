using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите дату в формате dd.MM.yyyy:");
        if (DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy", null, DateTimeStyles.None, out DateTime date))
        {
            string season = GetSeason(date);

            DayOfWeek dayOfWeek = date.DayOfWeek;
            string dayOfWeekName = dayOfWeek.ToString();

            Console.WriteLine($"{season} {dayOfWeekName}");
        }
        else
        {
            Console.WriteLine("Ошибка: Некорректный формат даты.");
        }
    }

    static string GetSeason(DateTime date)
    {
        int month = date.Month;

        if (month >= 3 && month <= 5)
        {
            return "Spring";
        }
        else if (month >= 6 && month <= 8)
        {
            return "Summer";
        }
        else if (month >= 9 && month <= 11)
        {
            return "Autumn";
        }
        else
        {
            return "Winter";
        }
    }
}
