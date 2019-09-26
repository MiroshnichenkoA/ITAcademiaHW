using System;

namespace Lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int num1 = 10;
            num1 = num1 + 1;
            num1 += 1;

            int num2 = 30;
            bool result = (num1 == num2);

            string num3 = "Hi!";

            bool isString = num3 is string;




        }
    }
}
