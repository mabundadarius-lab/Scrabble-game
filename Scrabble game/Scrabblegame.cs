using System;
using System.Collections.Generic;
using System.Text;

namespace Scrabble_game
{
    internal class Scrabblegame
    {

        //Properties for the scrabble game

        public string Word { get; set; }
        public double Score { get; set; }
        public int Level { get; set; }
        public string PlayerName { get; set; }
        public string Hint1 { get; set; }
        public string Hint2 { get; set; }
        public string Hint3 { get; set; }
        public bool IsGameOver { get; set; }

        //Constructer
        public Scrabblegame(string word, double score, int level, string playerName, string hint1, string hint2, string hint3, bool isgameover)
        {
            Word = word;
            Score = score;
            Level = level;
            PlayerName = playerName;
            Hint1 = hint1;
            Hint2 = hint2;
            Hint3 = hint3;
            IsGameOver = isgameover;
        }

        //Methods for the scrabble game
        public void playerName()
        {
            string playerName = Console.ReadLine();
            Console.WriteLine($"{PlayerName}");
        }


        public void CalculateScore()
        {
            // Simple logic: 10 points per letter
            Score = Word.Length * 10;
            Console.WriteLine($"Score for {Word}: {Score}");
        }
        public void ShowHint(int hintNumber)
        {
            if (hintNumber == 1) Console.WriteLine(Hint1);
            else if (hintNumber == 2) Console.WriteLine(Hint2);
            else Console.WriteLine(Hint3);
        }


    }
}
                