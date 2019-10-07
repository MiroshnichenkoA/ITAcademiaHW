using System;

namespace HW_04_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataMonth = new DateTime(2019, 09, 01);
            double currentDeposit = 1000;
            double groth = 0.02;

            for (int monthCount = 0; monthCount < 12; monthCount++)
            {
                double currentGroth = currentDeposit * groth;
                currentDeposit = currentDeposit + currentGroth;
                dataMonth = dataMonth.AddMonths(1);

                if (monthCount < 3) Console.WriteLine($"За {dataMonth} ваш вклад прирос на {currentGroth} рублей");
                else if (monthCount >= 3 & monthCount < 10) Console.WriteLine($"За {dataMonth} ваш вклад прирос на {currentGroth} рублей и составил {currentDeposit}");
                else Console.WriteLine($"По состоянию на {dataMonth} ваш вклад составил {currentDeposit}");
            }
        }
    }
}