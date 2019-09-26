using System;

namespace Lesson_3
{
    class Program
    {
        public static object Thred { get; private set; }

        static void Main(string[] args)
        {
            // первый пример +=
            int num1 = 10;
            num1 = num1 + 1;
            num1 += 1;

            //второй пример ==
            int num2 = 30;
            bool result = (num1 == num2);

            //третий пример is
            string num3 = "Hi!";

            bool isString = num3 is string;

            // четвертый пример switch
            var text = "Hello";
            switch (text)
            {
                case "Hello":
                    Console.WriteLine("I am here");
                    break;
                case "Hello, guys":
                case "Hello, guys!":
                    Console.WriteLine("Yes, I'm here!");
                    break;
                default:
                    Console.WriteLine("Smth goes wrong");
                    break;
            }
            //пятый пример циклов

            var text2 = "Hello, guys!";
            var length = text2.Length;

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(text2[i]);
            }

            foreach (var character in text2)
            {
                Console.WriteLine(character);
            }

            int num = 1;
            while (true)
            {
                num *= 2;
                Console.WriteLine(num);
            }
        }
    }
}
