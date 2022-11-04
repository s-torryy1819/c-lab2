using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_2
{
    public class PlayerStatistics
    {
        String userName = "";
        int currentRating;
        int gamesCount;
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
        public PlayerStatistics(String userName, int currentRating, int gamesCount)
        {
            UserName = userName;
            CurrentRating = currentRating;
            GamesCount = gamesCount;
        }
    }
}