using System;

namespace HomeWork_05_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какой длины будет массив?");
            string length = Console.ReadLine();
            uint lengthChecked;
            bool checkUserInputSuccess = uint.TryParse(length, out lengthChecked);
            while (checkUserInputSuccess == false)
            {
                Console.WriteLine("\a Используйте положительное целое число:");
                length = Console.ReadLine();
                checkUserInputSuccess = uint.TryParse(length, out lengthChecked);
            }
            lengthChecked = uint.Parse(length);

            Console.WriteLine("Введите целочисленные значения массива (за исключением последнего элемента):");
            int[] massiveFromConsole = new int[lengthChecked];
            for (int i = 0; i < massiveFromConsole.Length - 1; i++)
            {
               massiveFromConsole[i] = int.Parse(Console.ReadLine());
                Console.WriteLine(massiveFromConsole[i]);
            }
            Console.WriteLine("Какое значение примет последний элемент?");
            int userLastNumberForMassive = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер позиции данного элемента:");
            uint lastNumberRank = uint.Parse(Console.ReadLine());
            while (lastNumberRank > massiveFromConsole.Length)
            {
                Console.WriteLine("Вы ввели слишком большое число для позиции элемента в массиве заданной длины. \n Введите номер позиции данного элемента:");
                lastNumberRank = uint.Parse(Console.ReadLine());
            }
            int[] resultmassive = new int[lengthChecked];
            for (int i = 0; i < lastNumberRank - 1; i++)
            {
                resultmassive[i] = massiveFromConsole[i];
            }
            resultmassive[lastNumberRank - 1] = userLastNumberForMassive;
            for (int i = (int)lastNumberRank; i < resultmassive.Length; i++)
            {
                resultmassive[i] = massiveFromConsole[i-1];
            }
            foreach (var result in resultmassive)
            {
                Console.WriteLine(result);
            }
        }
    }
}
