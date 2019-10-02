using System;

namespace HW_04_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Куда будет двигаться игрок?");
            string symbol = Console.ReadLine();
            char move = ' ';

            if (symbol == "W") move = '\u2191';
            else if (symbol == "A") move = '\u2190';
            else if (symbol == "S") move = '\u2193';
            else if (symbol == "D") move = '\u2192';
            else move = ' ';

            switch (symbol)
            {
                case "W":
                case "A":
                case "S":
                case "D":
                    Console.WriteLine(move);
                    break;
                default:
                    Console.WriteLine("Игрок стоит на месте");
                    break;
            }
        }
    }
}
