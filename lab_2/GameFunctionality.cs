using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_2
{
    class GameFunctionality
    {
        public void findWinner(GameAccount player1, GameAccount player2, int ratingOfPlayer1, int ratingOfPlayer2)
        {
            if (ratingOfPlayer1 > ratingOfPlayer2)
            {
                player1.WinGame(player2.UserName, ratingOfPlayer1);
                player2.LoseGame(player1.UserName, ratingOfPlayer1);
            }
            else if (ratingOfPlayer2 > ratingOfPlayer1)
            {
                player2.WinGame(player1.UserName, ratingOfPlayer2);
                player1.LoseGame(player2.UserName, ratingOfPlayer1);
            }
            else
            {
                Console.WriteLine("Ratings are equal");
            }
        }
    }
}