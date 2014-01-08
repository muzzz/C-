using System;
using System.Globalization;
class TheGameBegins
{
    public static void Main()
    {
        
        string[] ans = new string[] {"RAT", "MAT", "STREAM", "TERM", "TERMS", "TEAR", "RATS", "MATS", "STAR", "SMART", "STARE", "MEAT", "MEATS", "TEARS", "TEA", "RATE", "MATE", "MATES", "SAT", "TAR", "TEAM", "TEAMS"};

        string[] inp = new string[ans.Length];

        int score = 0;

        string word;

        Console.WriteLine("Hello and welcome!");
        Console.WriteLine("The game is simple, all you need to do is write the possible outcomes of the word MASTER.");
        Console.WriteLine("The rules are simple, if you give me correct words, you gain 1 point, and if the words are incorrect you lose 1 point.");
        Console.WriteLine("Press S to begin the game, and Q to quit the game at any time.\nThe score will be displayed when you quit.");
        
                
        do { 
            word = Console.ReadLine().ToUpper();
            
            if (word == "Q")
            {
                Console.WriteLine("No stats displayed, as you didn't properly start the game yet.\n Press ENTER to exit.");
                Console.Read();
                return;
            }

            if (word != "S") 
                Console.WriteLine("ERROR: Invalid input! It can't be {0}. Try again!", word);

        } while(word != "S");
        
            Console.WriteLine("The game begins! Good luck and have fun. :)");
            int correctAnswers = 0;
         
        do {

            Console.WriteLine("Enter a word...");
            word = Console.ReadLine().ToUpper();

            if (CheckAnswer(inp, word))
            {
                if (score > 0)
                    score--;
                else
                    score = 0;

                Console.WriteLine("You entered the same word twice. Word: {0}, Score: {1}", word, score);

                continue;
            }

            if (CheckAnswer(ans, word))
            {
                score++;
                Console.WriteLine("Nice you found a word! The word you found is: {0}, \nAnd your score is: {1}", word, score);

                if(correctAnswers <= inp.Length)
                    inp[correctAnswers++] = word;
            }
            else
            {
                if (word != "Q")
                {
                    if (score > 0)
                        score--;
                    else
                        score = 0;

                    Console.WriteLine("You have entered an INVALID word. Word: {0}, Score: {1}", word, score);
                }
            }

            if (correctAnswers == ans.Length)
            {
                Console.WriteLine("Ok, you guessed all the answers. Nice!");
                break;
            }
        } while(word != "Q");

        if (word == "Q")       
            Console.WriteLine("Ok, so you gave up!\n");

            Console.WriteLine("Your score were: {0}, Correct answers: {1}\nHere is the answers:\n", score, correctAnswers);

        for (int i = 0; i < ans.Length; i++)
        
        if (CheckAnswer(ans, inp[i]))
            Console.WriteLine("WORD: {0}= You guessed this!", ans[i]);
         else 
            Console.WriteLine("WORD: {0}= You didn't guess this one!", ans[i]);
            Console.WriteLine("\nPress ENTER to exit.");
            Console.Read();
    }

    static bool CheckAnswer(string[] arr, string x)
    {

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
                return true;
        }

        return false;
    }
    
}
