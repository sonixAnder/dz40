using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число:");
        if (int.TryParse(Console.ReadLine(), out int num1))
        {
            Console.WriteLine("Введите второе число:");
            if (int.TryParse(Console.ReadLine(), out int num2))
            {
                if (num1 > num2)
                {
                    int temp = num1;
                    num1 = num2;
                    num2 = temp;
                }

                Console.WriteLine("Четные числа в диапазоне:");
                for (int i = num1; i <= num2; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($"{i} ");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Ошибка: Введено некорректное второе число.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка: Введено некорректное первое число.");
        }
    }
}
