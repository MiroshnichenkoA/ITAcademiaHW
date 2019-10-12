using System;

namespace HW_06_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseline = "Гусарский Павлоградский полк стоял в двух милях от Браунау";
            DeleteLongerWord(baseline);
            ChangePosition(baseline);
            CountChars(baseline);
            Sort(baseline);
        }

        static string DeleteLongerWord(string baseline)
        {
            string[] words = ToMassive(baseline);
            int howManyWordsToDelete = 1;
            int rankOfLongerWord = RankOfLongerWord(words);
            string[] newWords = new string[words.Length - howManyWordsToDelete];
            for (int i = 0; i < rankOfLongerWord; i++) newWords[i] = words[i];
            for (int i = rankOfLongerWord; i < newWords.Length; i++) newWords[i] = words[i + 1];
            string baselineDeleted = String.Join(" ", newWords);
            return baselineDeleted;
        }

        static string ChangePosition(string baseline)
        {
            string[] words = ToMassive(baseline);
            int rankOfLongerWord = RankOfLongerWord(words);
            int rankOfShoterWord = RankOfShoterWord(words);
            string longerWord = words[rankOfLongerWord];
            string shoterWord = words[rankOfShoterWord];
            words[rankOfLongerWord] = shoterWord;
            words[rankOfShoterWord] = longerWord;
            string baselineChanged = String.Join(" ", words);
            return baselineChanged;
        }
        static int CountChars(string baseline)
        {
            string[] words = ToMassive(baseline);
            int sum = 0;
            for (int i = 0; i < words.Length; i++)
            {
                sum += words[i].Length;
            }
            return sum;
        }

        static string[] Sort(string baseline)
        {
            string[] words = ToMassive(baseline);
            int[] lengthMassive = LengthMassive(words);
            int maxNum;
            int indexOfMax;
            int tempInt;
            string tempString;
            for (int i = 0; i < lengthMassive.Length; i++)
            {
                maxNum = lengthMassive[i];
                indexOfMax = i;
                for (int j = i; j < lengthMassive.Length; j++)
                {
                    if (maxNum < lengthMassive[j]) indexOfMax = j;
                }
                tempInt = lengthMassive[i];
                lengthMassive[i] = lengthMassive[indexOfMax];
                lengthMassive[indexOfMax] = tempInt;

                tempString = words[i];
                words[i] = words[indexOfMax];
                words[indexOfMax] = tempString;
            }
            return words;
        }

        static string[] ToMassive(string baseline)
        {
            string[] words = baseline.Split(" ");
            return words;
        }

        static int RankOfLongerWord(string[] words)
        {
            int maxLength = 0;
            int rank = 0;
            for (int i = 0; i < words.Length; i++)
            {
                int wordLength = words[i].Length;
                if (wordLength > maxLength)
                {
                    maxLength = wordLength;
                    rank = i;
                }
            }
            return rank;
        }

        static int RankOfShoterWord(string[] words)
        {
            int minLength = int.MaxValue;
            int rank = 0;
            for (int i = 0; i < words.Length; i++)
            {
                int wordLength = words[i].Length;
                if (wordLength < minLength)
                {
                    minLength = wordLength;
                    rank = i;
                }
            }
            return rank;
        }

        static int[] LengthMassive(string[] words)
        {
            int[] wordsLength = new int[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                wordsLength[i] = words[i].Length;
            }
            return wordsLength;
        }
}
}
