using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace WarGame
{
    class Game
    {
        //Member Variables - Declares variables that can be accessed anywhere in this class
        int playerOneScore;
        int playerTwoScore;

        //Constructor - Sets the scores to 0 when a new game is created
        public Game()
        {
            playerOneScore = 0;
            playerTwoScore = 0;
        }
        //Don't change anything above this ^^^^^^^^^^^^

        //Member Methods - All your methods go below here!

        public int RollDice()
        {
            int result = new Random().Next(1,6);
            Thread.Sleep(200);
            Console.WriteLine(result);
            return result;
        }

        public void CompareRolls(int rollOne, int rollTwo)
        {
            if (rollOne > rollTwo)
            {
                playerOneScore++;
                Console.WriteLine("Player One Wins!");
                Console.WriteLine("Press enter for another match...");
                Console.ReadLine();
            }
            else if (rollOne < rollTwo)
            {
                playerTwoScore++;
                Console.WriteLine("Player Two Wins!");
                Console.WriteLine("Press enter for another match...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Tie!");
                Console.WriteLine("Press enter for another match...");
                Console.ReadLine();
            }
        }


        public void DisplayGameWinner()
        {
            if (playerOneScore > playerTwoScore)
            {
                Console.WriteLine("Player One Wins the Game!");
            }
            else if (playerOneScore < playerTwoScore)
            {
                Console.WriteLine("Player Two Wins the Game!");
            }
            else
            {
                Console.WriteLine("It was a tie!");
            }
            
        }



        //This is the main method that is called in the Program when you press Start
        //Call your other methods inside this method
        public void RunGame()
        {
            bool nextGame = false;
            do
            {
                while (playerTwoScore != 3 && playerOneScore != 3)
                {
                    int rollOne = RollDice();
                    int rollTwo = RollDice();
                    CompareRolls(rollOne, rollTwo);

                }

                DisplayGameWinner();
                Console.WriteLine("Play another game? (y/n)");
                string inputText = Console.ReadLine();
                if (inputText == "y")
                {
                    nextGame = true;
                }
                else
                {
                    nextGame = false;
                }
            }
            while (nextGame == true);
            
        }
    }
}
