using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_2
{
    public class GameWithTwoPlayers : AbstractGame
    {
        public override void createGame()
        {
            GameAccount player1 = new GameAccount("Elisa", 0, 0);
            GameAccount player2 = new GameAccount("Max", 0, 0);
            GameFunctionality gameFunctionality = new GameFunctionality();
            player1.startNewGame();
            player2.startNewGame();
            Console.WriteLine("Game started");
            player1.setGoal();
            player2.setGoal();
            player1.setGoal(2);
            player2.setGoal();
            player2.setGoal();
            player2.setGoal();
            player1.setGoal();
            player2.setGoal();
            player2.setGoal();
            player1.GetStats();
            player2.GetStats();
            player2.setGoal();
            player1.setGoal();
            player1.setGoal();
            player2.setGoal();
            player2.setGoal();
            player2.setGoal();
            player1.setGoal();
            player1.GetStats();
            player2.GetStats();
            gameFunctionality.findWinner(player1, player2, player1.CurrentRating, player2.CurrentRating);
            player1.endGame();
            player2.endGame();
            Console.WriteLine("Game ended\n\nStatistics for players :");
            Console.WriteLine("User     " + player1.getStatistics()[0].UserName + "    " + player2.getStatistics()[0].UserName);
            Console.WriteLine("Game     " + player1.getStatistics()[0].GamesCount + "         " + player2.getStatistics()[0].GamesCount);
            Console.WriteLine("Rating   " + player1.getStatistics()[0].CurrentRating + "        " + player2.getStatistics()[0].CurrentRating);
        }

    }

}