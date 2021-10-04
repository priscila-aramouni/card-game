using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Card_Game
{
    public class Game
    {
        public List<Player> players = null;
        public List<Round> rounds = null;
        public static int GameCounter = 0;
        public string GameEntry;

        public Game(List<Player> Players)
        {
            players = Players;
            rounds = null;
            GameCounter++;
        }

        public bool has3Players()
        {
            if (players.Count() == 3)
                return true;
            else
                return false;
        }

        public bool has2Players()
        {
            if (players.Count() == 2)
                return true;
            else
                return false;
        }

       public Player Winner()
        {
            Player winner = players[0];

            for(int i = 1; i < players.Count; i++)
            {
                if(players[i].score > winner.score)
                {
                    winner = players[i];
                }
            }

            return winner;
        }

        public override string ToString()
        {
            string GameEntry = null;

            GameEntry = $"Game {GameCounter}: {this.Winner().name} won, Score = {this.Winner().score}";

            return GameEntry;
        }
    }
}
