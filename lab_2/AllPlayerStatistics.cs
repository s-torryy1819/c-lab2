using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_2
{
    public class AllPlayerStatistics
    {
        List<PlayerStatistics> statisticsList = new List<PlayerStatistics>();
        public void addDataPoint(String userName, int currentRating, int gamesCount)
        {
            PlayerStatistics playerStatistics = new PlayerStatistics(userName, currentRating, gamesCount);
            statisticsList.Add(playerStatistics);
        }
        public List<PlayerStatistics> getStatisticsList()
        {
            return statisticsList;
        }
    }
}