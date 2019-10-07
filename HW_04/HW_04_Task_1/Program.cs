using System;

namespace HW_04_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char letter = '\u005A'; letter != '\u0041'-1; letter--)
            {
                Console.WriteLine(letter);
            }
        }
    }
}
