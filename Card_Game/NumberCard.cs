using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Card_Game
{
    public class NumberCard : Card
    {
        public int value;

        public NumberCard(int Value, char Symbol)
            : base()
        {
            value = Value;
            symbol = Symbol;
        }

        public override string ToString()
        {
            return $"{value}{symbol}";
        }

        public override string ToRoundEntryString()
        {
            string ValueString = value.ToString();
            string SymbolString = null;
            
            if(value == 1)
            {
                ValueString = "Ace";
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

            return $"{ValueString} of {SymbolString}";
        }

        public override bool isPictureCard()
        {
            return false;
        }

        public override bool isNumberCard()
        {
            return true;
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
