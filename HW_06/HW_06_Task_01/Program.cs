using System;

namespace HW_06_Task_01
{
    class Program
    {
        const char separator = '\u003B';
        static void Main(string[] args)
        {
            string question = $"Введи стихотворение в одну строку, разделяя строки знаком \"{separator}\"";
            Console.WriteLine(question);
            string poemFromUser = GetPoemFromUser();
            string[] poem = PoemSeparator(poemFromUser);
            poem = LetterReplacer(poem);
            PoemReader(poem);
        }

        static string GetPoemFromUser()
        {
            string poemFromUser = Console.ReadLine();
            return poemFromUser;
        }

        static string[] PoemSeparator(string poemFromUser)
        {
           string[] poem = poemFromUser.Split(separator);
           return poem;
        }

        static string[] LetterReplacer(string[] poem)
        {
            for (int i = 0; i < poem.Length; i++)
            {
                string frase = Convert.ToString(poem[i]);
                frase = frase.Replace("о", "а");
                frase = frase.Replace("О", "А");
                poem[i] = frase;
            }
            return poem;
        }

        static void PoemReader(string[] poem)
        {
            foreach (var poemLine in poem)
            {
                Console.WriteLine(poemLine); //method foreach will write poem line by line
            }
        }
    }
}
