using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Card_Game
{
    public class Round
    {
        public List<Player> players;
        public static int RoundCount = 0;
        public string RoundEntry;

        public Round(List<Player> Players)
        {
            players = Players;
            RoundCount++;    
        }

        public override string ToString()
        {
            string RoundEntry = null;

            if (players.Count == 2)
            {
                RoundEntry = $"Round {RoundCount}:  {players[0].name} {players[0].scoreDifference.ToString()} ({players[0].dealtCard.ToRoundEntryString()})  ||  " +
                             $"{players[1].name} {players[1].scoreDifference.ToString()} ({players[1].dealtCard.ToRoundEntryString()}\n)";
            }

            else if (players.Count == 3)
            {
                RoundEntry = $"Round {RoundCount}:  {players[0].name} {players[0].scoreDifference.ToString()} ({players[0].dealtCard.ToRoundEntryString()})  ||  " +
                            $"{players[1].name} {players[1].scoreDifference.ToString()} ({players[1].dealtCard.ToRoundEntryString()})  ||  " +
                            $"{players[2].name} {players[2].scoreDifference.ToString()} ({players[2].dealtCard.ToRoundEntryString()})\n";

            }

            return RoundEntry;
        }
    }
}
