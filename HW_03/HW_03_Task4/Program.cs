using System;

namespace HW_03_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добрый день! Введите первое число: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Теперь введите второе число: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Выберите и введите оператор (+/-): ");
            string @operator = Console.ReadLine();

            int flag = 0;
            double result =0;
            double answer = 0;

            while (flag != 1)
            { if (@operator == "+") {
                  result = Sum(number1, number2);
                    flag = 1;
                    Console.WriteLine($"Сколько будет, если мы сложим {number1} и {number2}?");
                    answer = Convert.ToDouble(Console.ReadLine());
                }
                else if (@operator == "-") {
                    result = Min(number1, number2);
                    flag = 1;
                    Console.WriteLine($"Сколько будет, если мы из {number1} вычтем {number2}?");
                    answer = Convert.ToDouble(Console.ReadLine());
                }
            else
                {
                    Console.WriteLine("Вы ввели некорректный оператор. Выберите и введите оператор (+/-): ");
                    @operator = Console.ReadLine();
                }
            }

            if (answer == result) Console.WriteLine("Правильно!");
            else
            {
                while (answer != result)
                {
                    double gap = answer - result;
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
            double result = x + y;
            return result;
        }

        static double Min(double x, double y)
        {
            double result = x - y;
            return result;
        }
    }
}
