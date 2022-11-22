using System;

namespace lab_2
{
    class GameAccount : GameAccountAbstract
    {
        new public String userName = "";
        new public int currentRating;
        new public int gamesCount;
        AllPlayerStatistics allPlayerStatistics = new AllPlayerStatistics();
        public String UserName
        {
            get { return userName; }
            set
            {
                userName = value;
            }
        }
        public int CurrentRating
        {
            get { return currentRating; }
            set
            {
                currentRating = value;
            }
        }
        public int GamesCount
        {
            get { return gamesCount; }
            set
            {
                gamesCount = value;
            }
        }
        public GameAccount(String userName, int currentRating, int gamesCount)
        {
            UserName = userName;
            CurrentRating = currentRating;
            GamesCount = gamesCount;
        }
        public override void startNewGame()
        {
            currentRating = 0;
            gamesCount++;
        }
        public override void endGame()
        {
            allPlayerStatistics.addDataPoint(userName, currentRating, gamesCount);
            currentRating = 0;
        }
        public override void setGoal()
        {
            currentRating++;
        }
        public override void setGoal(int goal)
        {
            currentRating += goal;
        }
        public override List<PlayerStatistics> getStatistics()
        {
            return allPlayerStatistics.getStatisticsList();
        }
        public override AbstractGame WinGame(String opponentName, int rating)
        {
            AbstractGame abstractGame = new GameWithTwoPlayers();
            abstractGame.WinGame(userName);
            Console.WriteLine(abstractGame.getWinner() + " won!!!\nRating : " + currentRating + "\nThe opponent : " + opponentName + "\n........");
            return abstractGame;
        }
        public override AbstractGame LoseGame(String opponentName, int rating)
        {
            AbstractGame abstractGame = new GameWithTwoPlayers();
            abstractGame.LoseGame(userName);
            Console.WriteLine(abstractGame.getLoser() + " losed...\nRating : " + currentRating + "\nThe opponent : " + opponentName + "\n........");
            return abstractGame;
        }
        public override void GetStats()
        {
            Console.WriteLine("Game Statistics\nUserName : " + userName + "\nRating : " + currentRating + "\nCount : " + gamesCount + "\n........");
        }
        public static bool checkRating(int rating)
        {
            if (rating < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "Rating can not be less than 1\n");
            }
            return true;
        }
    }
}