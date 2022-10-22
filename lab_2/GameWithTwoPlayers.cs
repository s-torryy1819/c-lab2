using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_1
{
    public class GameWithTwoPlayers : AbstractGame
    {
        public override void createGame()
        {
            GameAccount player1 = new GameAccount("Elisa", 0, 0);
            GameAccount player2 = new GameAccount("Max", 0, 0);
            player1.startNewGame();
            player2.startNewGame();
            GameRun newGame = new GameRun();
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
            newGame.findWinner(player1, player2, player1.CurrentRating, player2.CurrentRating);
            player1.endGame();
            player2.endGame();
            Console.WriteLine("Game ended");
        }

    }

}