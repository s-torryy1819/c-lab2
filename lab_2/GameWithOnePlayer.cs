using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_1
{
    public class GameWithOnePlayer : AbstractGame
    {
        public override void createGame()
        {
            GameAccount2 player = new GameAccount2("Sophie", 0, 6);
            player.startNewGame();
            Console.WriteLine("Game started");
            player.setGoal(5);
            player.GetStats();
            player.setGoal(4);
            player.setGoal();
            player.GetStats();
            player.endGame();
            Console.WriteLine("Game ended");
        }
    }
}