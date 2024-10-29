using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите шестизначное число:");
        if (int.TryParse(Console.ReadLine(), out int number) && number >= 100000 && number <= 999999)
        {
            Console.WriteLine("Введите номер первого разряда (от 1 до 6):");
            if (int.TryParse(Console.ReadLine(), out int digit1) && digit1 >= 1 && digit1 <= 6)
            {
                Console.WriteLine("Введите номер второго разряда (от 1 до 6):");
                if (int.TryParse(Console.ReadLine(), out int digit2) && digit2 >= 1 && digit2 <= 6)
                {
                    int[] digits = new int[6];
                    for (int i = 5; i >= 0; i--)
                    {
                        digits[i] = number % 10;
                        number /= 10;
                    }
                    int temp = digits[digit1 - 1];
                    digits[digit1 - 1] = digits[digit2 - 1];
                    digits[digit2 - 1] = temp;

                    int result = digits[0] * 100000 + digits[1] * 10000 + digits[2] * 1000 + digits[3] * 100 + digits[4] * 10 + digits[5];

                    Console.WriteLine($"Измененное число: {result}");
                }
                else
                {
                    Console.WriteLine("Ошибка: Некорректный номер второго разряда.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: Некорректный номер первого разряда.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: Введено не шестизначное число.");
        }
    }
}
