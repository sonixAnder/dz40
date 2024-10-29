using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число:");
        if (double.TryParse(Console.ReadLine(), out double value))
        {
            Console.WriteLine("Введите процент:");
            if (double.TryParse(Console.ReadLine(), out double percent))
            {
                double result = (percent / 100) * value;

                Console.WriteLine($"{percent} процентов от {value} равно: {result}");
            }
            else
            {
                Console.WriteLine("Ошибка: Введено неверное значение процента.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: Введено неверное значение числа.");
        }

        Console.ReadKey();
    }
}
