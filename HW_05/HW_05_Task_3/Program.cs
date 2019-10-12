using System;

namespace HW_05_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] massiveForReverse = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int[] reversedMassive = new int[massiveForReverse.Length];
            for (int i = 0; i < massiveForReverse.Length; i++)
            {
                reversedMassive[i] = massiveForReverse[massiveForReverse.Length - 1 - i];
                Console.WriteLine(reversedMassive[i]);
            }
        }
    }
}
