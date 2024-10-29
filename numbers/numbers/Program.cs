using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите четыре цифры:");

        int[] digits = new int[4];

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"Введите цифру {i + 1}:");

            if (int.TryParse(Console.ReadLine(), out int digit) && digit >= 0 && digit <= 9)
            {
                digits[i] = digit;
            }
            else
            {
                Console.WriteLine("Ошибка: Введите корректную цифру от 0 до 9.");
                return;
            }
        }

        int result = digits[0] * 1000 + digits[1] * 100 + digits[2] * 10 + digits[3];

        Console.WriteLine($"Сформированное число: {result}");
    }
}
