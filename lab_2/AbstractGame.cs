using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_2
{
    public abstract class AbstractGame
    {
        public String winner = "";
        public String loser = "";
        public virtual void createGame()
        {
            Console.WriteLine("Game started");
        }
        public virtual void WinGame(String userName)
        {
            winner = userName;
        }
        public virtual void LoseGame(String userName)
        {
            loser = userName;
        }
        public virtual String getWinner()
        {
            return winner;
        }
        public virtual String getLoser()
        {
            return loser;
        }
    }
}