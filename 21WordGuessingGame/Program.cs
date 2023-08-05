using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // RANDOM WORD GAME USING RANDOM CLASS, INSERT, AND REMOVE
            // USES FOR LOOPS
            // USES IF STATEMENTS


            // List of random words in game
             string[] words = {"jump", "hello", "graymont", "programmer", "breaking", "finally", "rebuild", "justify",
             "bring", "rebound", "helping", "building", "never", "challenge", "welcoming", "january", "humble", "trinity", "just",
             "remember", "engineer"};

            // // Our random class to pick the random word for the game
             Random random = new Random();
             int randomIndex = random.Next(0, 21);
             string selectedWord = words[randomIndex];
             string hiddenWord = "";

             for (int i = 0; i < selectedWord.Length; i++)
             {
                 hiddenWord += "*";
             }
            // // Source code for the guessing portion of game
            // // Will run as long as '*' still exists in the hidden word
             while (hiddenWord.Contains("*"))
             {
                 Console.WriteLine("21 Word Guess");
                 Console.WriteLine("Word: {0}", hiddenWord);
                 Console.Write("Guess the letter in the hidden word >>> ");
                 char letter = char.Parse(Console.ReadLine());
                 bool containsLetter = false;

                 for (int i = 0; i < selectedWord.Length; i++)
                 {
                     if (selectedWord[i] == letter)
                     {
                     hiddenWord = hiddenWord.Remove(i, 1);
                     hiddenWord = hiddenWord.Insert(i, letter.ToString());
                     containsLetter = true;

                     }

                 }
                 if (containsLetter == true)
                 {
                     Console.ForegroundColor = ConsoleColor.Green;
                     Console.WriteLine("{0} is in the word!", letter);
                 }
                 else
                 {
                     Console.ForegroundColor = ConsoleColor.Red;
                     Console.WriteLine("Sorry, {0} is not in the word", letter);
                 }
                 Console.ResetColor();
             }
             Console.WriteLine("Congrats! You win!");
             Console.WriteLine("The hidden word is {0}", selectedWord);

        }
    }
}