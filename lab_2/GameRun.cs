using System;

namespace lab_1
{
    class GameRun
    {

        static void Main(string[] args)
        {
            AbstractGame game1 = new GameWithOnePlayer();
            AbstractGame game2 = new GameWithTwoPlayers();
            ConvertGameToBasic convertGame = new ConvertGameToBasic();
            game1.createGame();
            Console.WriteLine("\nNext game...\n");
            game2.createGame();
        }
        public void findWinner(GameAccount user1, GameAccount user2, int ratingOfUser1, int ratingOfUser2)
        {
            if (ratingOfUser1 > ratingOfUser2)
            {
                user1.WinGame(user2.UserName, ratingOfUser1);
                user2.LoseGame(user1.UserName, ratingOfUser1);
            }
            else if (ratingOfUser2 > ratingOfUser1)
            {
                user2.WinGame(user1.UserName, ratingOfUser2);
                user1.LoseGame(user2.UserName, ratingOfUser1);
            }
            else
            {
                Console.WriteLine("Ratings are equal");
            }
        }
    }
}