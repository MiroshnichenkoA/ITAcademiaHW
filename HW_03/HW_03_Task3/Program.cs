using System;

namespace HW_03_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добрый день! Введите первое число: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Теперь введите второе число: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double sum = Sum(number1, number2);

            Console.WriteLine($"Сколько будет, если мы сложим {number1} и {number2}?");
            double answer = Convert.ToDouble(Console.ReadLine());

            if (answer == sum) Console.WriteLine("Правильно!");
            else
            {
                while (answer != sum)
                {
                    double gap = answer - sum;
                    string gap1 = "Должно быть больше.";
                    string gap2 = "Должно быть меньше.";

                    if (gap < 0) Console.WriteLine($"Не правильно :( {gap1} Давай попробуем еще раз? Сколько будет, если мы сложим {number1} и {number2}?");
                    else Console.WriteLine($"Не правильно :( {gap2} Давай попробуем еще раз? Сколько будет, если мы сложим {number1} и {number2}?");
                    answer = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine("Правильно!");
            }
        }

        static double Sum(double x, double y)
        {
            double sum = x + y;
            return sum;
        }
    }
}
