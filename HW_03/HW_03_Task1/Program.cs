using System;

namespace HW_03_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добрый день! Для сложения чисел, пожалуйста, введите первое число: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Теперь введите второе число: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double sum = Sum(number1, number2);

            Console.WriteLine($"Сумма чисел {number1} и {number2} равна {sum}!");
        }

        static double Sum(double x, double y)
        {
            double sum = x + y;
            return sum;
        }
    }
}
