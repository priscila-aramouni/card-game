using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Card_Game
{

    public class PictureCard : Card
    {
        public char type; //J,K,Q

        public PictureCard(char Type, char Symbol)
            : base(Symbol)
        {
            type = Type;
        }

        public override string ToString()
        {
            return $"{type}{symbol}";
        }

        public override string ToRoundEntryString()
        {
            string TypeString = null;
            string SymbolString = null;

            switch (this.type)
            {
                case 'J':
                    TypeString = "Jack";
                    break;

                case'Q':
                    TypeString = "Queen";
                    break;

                case 'K':
                    TypeString = "King";
                    break;
            }

            switch (this.symbol)
            {
                case 'C':
                    SymbolString = "Clubs";
                    break;

                case 'D':
                    SymbolString = "Diamonds";
                    break;

                case 'H':
                    SymbolString = "Hearts";
                    break;

                case 'S':
                    SymbolString = "Spades";
                    break;
            }

            return $"{TypeString} of {SymbolString}"; 
        }

        public override bool isPictureCard()
        {
            return true;
        }

        public override bool isNumberCard()
        {
            return false;
        }

        public override bool isBlackCard()
        {
            if (this.symbol == 'S' || this.symbol == 'C')
                return true;
            else
                return false;
        }

        public override bool isRedCard()
        {
            if (this.symbol == 'H' || this.symbol == 'D')
                return true;
            else
                return false;
        }
    }
}
