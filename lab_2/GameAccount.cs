using System;

namespace lab_2
{
    class GameAccount
    {
        public String userName = "";
        public int currentRating;
        public int gamesCount;
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
        public void startNewGame()
        {
            currentRating = 0;
            gamesCount++;
        }
        public void endGame()
        {
            allPlayerStatistics.addDataPoint(userName, currentRating, gamesCount);
            currentRating = 0;
        }
        public void setGoal()
        {
            currentRating++;
        }
        public void setGoal(int goal)
        {
            currentRating += goal;
        }
        public List<PlayerStatistics> getStatistics()
        {
            return allPlayerStatistics.getStatisticsList();
        }
        public AbstractGame WinGame(String opponentName, int rating)
        {
            AbstractGame abstractGame = new GameWithTwoPlayers();
            abstractGame.WinGame(opponentName, rating, currentRating, userName);
            return abstractGame;
        }
        public AbstractGame LoseGame(String opponentName, int rating)
        {
            AbstractGame abstractGame = new GameWithTwoPlayers();
            abstractGame.LoseGame(opponentName, rating, currentRating, userName);
            return abstractGame;
        }
        public void GetStats()
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