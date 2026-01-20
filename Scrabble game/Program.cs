using System;
using System.Collections.Generic;

namespace Scrabble_game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduction of the player name

            Console.WriteLine("Enter your name: ");
            string playerName = Console.ReadLine();

            // Create the list of 15 levels - add more leveles
            List<Scrabblegame> levels = new List<Scrabblegame>();

            // Adding levels (Showing first 3 as examples - you can fill in the rest)
            levels.Add(new Scrabblegame("CAT", 0, 1, "Player1", "Small pet", "Meows", "Likes milk", false));
            levels.Add(new Scrabblegame("DOG", 0, 2, "Player1", "Barks", "Man's best friend", "Tail wagger", false));
            levels.Add(new Scrabblegame("APPLE", 0, 3, "Player1", "Red fruit", "Keeps doctor away", "Tech logo", false));
            levels.Add(new Scrabblegame("LDIL", 0, 4, "Player1", "Has white tables", "Has expensive screens", "Has 15 girls and 10 boys", false));
            levels.Add(new Scrabblegame("COMPUTER", 0, 5, "Player1", "Electronic device", "Used for coding", "Has a keyboard", false));
            levels.Add(new Scrabblegame("TIKTOK" , 0, 6, "Player1", "Popular app", "Short videos", "it has a bird logo", false));
            // ... add levels 4 through 15 here ...

            foreach (var currentLevel in levels)
            {
                bool levelCleared = false;

                // Store hints in an array for easy looping
                string[] hints = { currentLevel.Hint1, currentLevel.Hint2, currentLevel.Hint3 };

                Console.Clear();
                Console.WriteLine("-Welcome to the LDIL Scramble Game-");
                Console.WriteLine($"------------- LEVEL {currentLevel.Level} -------------");

                // Loop through the 3 hints
                for (int h = 0; h < hints.Length; h++)
                {
                    Console.WriteLine($"\nHint {h + 1}: {hints[h]}");
                    Console.Write("Your Guess: ");
                    string guess = Console.ReadLine();

                    if (guess.ToUpper() == currentLevel.Word.ToUpper())
                    { //colour green for the colour
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("CORRECT! Well done.");
                        //collour reverse back to white
                        Console.ForegroundColor = ConsoleColor.White;
                       levelCleared = true;
                        // it is for a delay by 1 sec after completing a level
                        System.Threading.Thread.Sleep(1000);
                        break; // exit the hint loop
                    }
                    else
                    {
                        if (h < 2)
                        {  //changes  the text to Red when the entered answer is wrong 
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Wrong! Try the next hint...");//break;
                            // colour  back to white
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.WriteLine($"Out of hints! The word was: {currentLevel.Word}");
                            // delays by 2 sec 
                            System.Threading.Thread.Sleep(2000);
                        }
                    }
                }

                
            }

            Console.WriteLine();
            Console.WriteLine($"--- Game Over! Thanks for playing {playerName}---");
        }
    }
}