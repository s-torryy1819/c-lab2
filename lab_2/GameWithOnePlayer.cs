using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_2
{
    public class GameWithOnePlayer : AbstractGame
    {
        public override void createGame()
        {
            GameAccount player = new GameAccount("Sophie", 0, 6);
            player.startNewGame();
            Console.WriteLine("Game started");
            player.setGoal(5);
            player.GetStats();
            player.setGoal(4);
            player.setGoal();
            player.GetStats();
            player.endGame();
            Console.WriteLine("Game ended\n\nStatistics for player :");
            Console.WriteLine("User     " + player.getStatistics()[0].UserName);
            Console.WriteLine("Game     " + player.getStatistics()[0].GamesCount);
            Console.WriteLine("Rating   " + player.getStatistics()[0].CurrentRating);
        }
    }
}