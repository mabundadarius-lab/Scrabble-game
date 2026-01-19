using System;
using System.Collections.Generic;
using System.Text;

namespace Scrabble_game
{
    internal class Scrabblegame
    {

        //Properties for the scrable game

        public string Word { get; set; }
        public double Score { get; set; }
        public int Level { get; set; }
        public string PlayerName { get; set; }
        public string Hint1 { get; set; }
        public string Hint2 { get; set; }
        public string Hint3 { get; set; }
        public bool IsGameOver { get; set; }

        //Constructer
        public Scrabblegame(string word, double score, int level, string playername, string hint1, string hint2, string hint3, bool isgameover)
        {
            Word = word;
            Score = score;
            Level = level;
            PlayerName = playername;
            Hint1 = hint1;
            Hint2 = hint2;
            Hint3 = hint3;
            IsGameOver = isgameover;
        }

        //Methods for the scrable game
        public void playername()
        {
            Console.WriteLine($"{PlayerName}");
        }



    }
}
