
using System;

namespace AWordGuessingGame;

class HangmanGame
{

    static void Main()
    {
        
        string secretWord = Utilities.GetRandomWord();

        
        int attemptsLeft = 10; 
        string guessedWord = new string('_', secretWord.Length);
        string incorrectGuesses = "";

        
        while (attemptsLeft > 0)
        {
            
            Console.WriteLine($"Word: {guessedWord}");
            Console.WriteLine($"Incorrect Guesses: {incorrectGuesses}");
            Console.WriteLine($"Attempts Left: {attemptsLeft}");

            
            Console.Write("Enter a letter: ");
            char guess = char.ToLower(Console.ReadKey().KeyChar);

            
            if (secretWord.Contains(guess))
            {
                
                for (int i = 0; i < secretWord.Length; i++)
                {
                    if (secretWord[i] == guess)
                    {
                        guessedWord = guessedWord.Substring(0, i) + guess + guessedWord.Substring(i + 1);
                    }
                }

                
                if (guessedWord == secretWord)
                {
                    Console.WriteLine($"\nCongratulations! You guessed the word: {secretWord}");
                    break;
                }
            }
            else
            {
                
                Console.WriteLine("\nIncorrect guess. Try again.");
                attemptsLeft--;
                incorrectGuesses += guess;
            }
        }

        
        if (attemptsLeft == 0)
        {
            Console.WriteLine($"\nSorry, you're out of attempts. The word was: {secretWord}");
        }
    }

}


    
    


