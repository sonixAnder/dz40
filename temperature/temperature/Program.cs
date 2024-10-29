using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите показания температуры:");
        if (double.TryParse(Console.ReadLine(), out double temperature))
        {
            Console.WriteLine("Выберите преобразование:");
            Console.WriteLine("1. Фаренгейт в Цельсий");
            Console.WriteLine("2. Цельсий в Фаренгейт");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        double celsius = (temperature - 32) * 5 / 9;
                        Console.WriteLine($"{temperature} градусов Фаренгейта = {celsius:F2} градусов Цельсия");
                        break;

                    case 2:
                        double fahrenheit = temperature * 9 / 5 + 32;
                        Console.WriteLine($"{temperature} градусов Цельсия = {fahrenheit:F2} градусов Фаренгейта");
                        break;

                    default:
                        Console.WriteLine("Неверный выбор. Пожалуйста, введите 1 или 2.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ошибка: Некорректный выбор.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: Некорректное значение температуры.");
        }
    }
}
