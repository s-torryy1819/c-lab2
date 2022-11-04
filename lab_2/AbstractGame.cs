using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_2
{
    public abstract class AbstractGame
    {
        public virtual void createGame()
        {
            Console.WriteLine("Game started");
        }
        public virtual void WinGame(String opponentName, int rating, int currentRating, String userName)
        {
            Console.WriteLine(userName + " won!!!\nRating : " + currentRating + "\nThe opponent : " + opponentName + "\n........");
        }
        public virtual void LoseGame(String opponentName, int rating, int currentRating, String userName)
        {
            Console.WriteLine(userName + " losed...\nRating : " + currentRating + "\nThe opponent : " + opponentName + "\n........");
        }
    }
}