using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Card_Game
{
    public abstract class Card
    {
        public char symbol; //C,D,H,S

        public Card()
        {

        }

        public Card(char Symbol)
        {
            symbol = Symbol;
        }

        abstract public override string ToString();
        abstract public string ToRoundEntryString();
        abstract public bool isPictureCard();
        abstract public bool isNumberCard();
        abstract public bool isRedCard();
        abstract public bool isBlackCard();
    }
}
