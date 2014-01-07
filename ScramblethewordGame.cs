using System;
using System.Globalization;
class TheGameBegins
{
    public static void Main()
    {
        //Display the word "MASTER"
        //Possible scrambled outcomes of MASTER are { RAT, MAT, SAT, REST, STREAM, MATE, MATES, RATE, RATES, SMART, STARE, MEAT, MEATS, TEAR, TEARS}
        //Accept input from the user
        string[] ans = new string[] {"RAT", "MAT", "STREAM", "TERM", "TEAR", "RATS", "MATS"}; // The answers
 
        string[] inp = new string[ans.Length]; // The correct answers are stored here
 
        int score = 0;
 
        string word;
 
        Console.WriteLine("Hello and welcome!");
        Console.WriteLine("The game is simple, all you need to do is write the possible outcomes of the word MASTER.");
        Console.WriteLine("The rules are simple, if you give me correct words, you gain 1 point, and if the words are incorrect you lose 1 point.");
        Console.WriteLine("Press S to begin the game, and Q to quit the game at any time.\nThe score will be displayed when you quit.");
       
        //Console.ReadLine();
       
        do { // Does the code below
            word = Console.ReadLine().ToUpper(); // Waits for the user to input a string or letter
 
            //if (word == "Q") // If variable word happens to be Q, end the program as this is the main function.
                //return;
            if (word == "Q")
            {
                Console.WriteLine("No stats displayed, as you didn't properly start the game yet.\n Press ENTER to exit.");
                Console.Read();
                return;
            }
 
            if (word != "S") // If the word variable is NOT S, display error message
                Console.WriteLine("ERROR: Invalid input! It can't be {0}. Try again!", word);
 
        } while(word != "S"); // Continue the loop until S is inside variable word
 
        //Console.WriteLine(Array.Find(ans, e => e.Equals("RAT")));
 
        Console.WriteLine("The game begins! Good luck and have fun. :)");
        int correctAnswers = 0;
         
        do {
 
            Console.WriteLine("Enter a word...");
            word = Console.ReadLine().ToUpper();
 
            if (CheckAnswer(inp, word)) // Duplicate
            {
                if (score > 0)
                    score--;
                else
                    score = 0;
 
                Console.WriteLine("You entered the same word twice. Word: {0}, Score: {1}", word, score);
 
                continue;
            }
 
            if (CheckAnswer(ans, word)) // Answer
            {
                score++;
                Console.WriteLine("You found a word! Word: {0}, Score: {1}", word, score);
 
                if(correctAnswers <= inp.Length)
                    inp[correctAnswers++] = word; // Post increment
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
            Console.WriteLine("WORD: {0}", ans[i]); // How to display the correct answers WORD: ANS = INP on correct answers
 
        // WORD: RATS
        // WORD: TEAR = TEAR
 
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
 
        // Can only return TRUE or FALSE (1, 0)
    }
}
