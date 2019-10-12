using System;

namespace HW_05_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какой длины будет массив?");
            string length =  Console.ReadLine();
            uint lengthChecked;
            bool checkUserInputSuccess = uint.TryParse(length, out lengthChecked);
            while (checkUserInputSuccess == false)
            {
                Console.WriteLine("\a Используйте положительное целое число:");
                length = Console.ReadLine();
                checkUserInputSuccess = uint.TryParse(length, out lengthChecked);
            }
            lengthChecked = uint.Parse(length);

            int[] randomMassive = new int[lengthChecked];
            int[] consoleMassive = new int[lengthChecked];
            int[] resultMassive = new int[lengthChecked];

            Console.WriteLine("Первый массив зададим рандомно:");
            for (int i = 0; i < randomMassive.Length; i++)
            {
                Random fortuna = new Random();
                randomMassive[i] = fortuna.Next();
                Console.WriteLine(randomMassive[i]);
            }
            Console.WriteLine("Задайте значения второго массива самостоятельно:");
            for (int i = 0; i < consoleMassive.Length; i++)
            {
                   consoleMassive[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Сложив значения массивов мы получим:");
            for (int i = 0; i < resultMassive.Length; i++)
            {
                resultMassive[i] = randomMassive[i] + consoleMassive[i];
                Console.WriteLine(resultMassive[i]);
            }
        }
        private static bool TryParse(string length, uint uInt32)
        {
            throw new NotImplementedException();
        }
    }
}
