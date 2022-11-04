using System;

namespace lab_2
{
    class GameRun
    {
        static void Main(string[] args)
        {
            GameWithOnePlayer game1 = new GameWithOnePlayer();
            GameWithTwoPlayers game2 = new GameWithTwoPlayers();
            game1.createGame();
            Console.WriteLine("\nNext game...\n");
            game2.createGame();
        }
    }
}