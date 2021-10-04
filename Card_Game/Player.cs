using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Card_Game
{
    public class Player
    {
        public string name;
        public string type;
        public int score;
        public int scoreDifference;
        public int maxScore;
        public Card dealtCard;

        public Player(string playerName, string playerType)
        {
            name = playerName;
            type = playerType;           
            score = 0;
            maxScore = 5;
            scoreDifference = 0;
            dealtCard = null;
        }
    }
}
