namespace lab_2
{
    public abstract class GameAccountAbstract
    {
        public String userName = "";
        public int currentRating;
        public int gamesCount;
        public virtual void startNewGame()
        {
            currentRating = 0;
            gamesCount++;
        }
        public virtual void endGame()
        {
            currentRating = 0;
        }
        public virtual void setGoal()
        {
            currentRating++;
        }
        public virtual void setGoal(int goal)
        {
            currentRating += goal;
        }
        public virtual List<PlayerStatistics> getStatistics()
        {
            return new List<PlayerStatistics>();
        }
        public virtual AbstractGame WinGame(String opponentName, int rating)
        {
            return null;
        }
        public virtual AbstractGame LoseGame(String opponentName, int rating)
        {
            return null;
        }
        public virtual void GetStats()
        {
            Console.WriteLine("Game Statistics\nUserName : " + userName + "\nRating : " + currentRating + "\nCount : " + gamesCount + "\n........");
        }
    }
}