using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Card_Game
{
    class Deck
    {
        public Card[] TheDeck = new Card[52];
        static Random randNum = new Random();

        //Keeping track of dealt cards and nb. of cards left in deck
        public int dealIndex = 0;
        public int deckSize = 52;

        public Deck()
        {
            int[] CardNumber = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            char[] CardSymbol = new char[4] { 'C', 'D', 'H', 'S' };
            char[] CardPicture = new char[3] { 'J', 'K', 'Q' };

            //The deck will have 40 NumberCards
            Card[] NumberCards = new Card[40];
            for (int i = 0; i < 40; i++)
            {
                NumberCards[i] = new NumberCard(CardNumber[i % 10], CardSymbol[i / 10]);
            }

            //The deck will have 12 PictureCards 
            Card[] PictureCards = new Card[12];
            for (int j = 0; j < 12; j++)
            {
                PictureCards[j] = new PictureCard(CardPicture[j % 3], CardSymbol[j / 3]);
            }

            TheDeck = NumberCards.Concat(PictureCards).ToArray();
            this.Shuffle();
        }

        public void Shuffle()
        {
            for (int n = TheDeck.Length - 1; n > 0; --n)
            {
                int k = randNum.Next(n + 1);
                Card temp = TheDeck[n];
                TheDeck[n] = TheDeck[k];
                TheDeck[k] = temp;
            }
        }

        public Card Deal()
        {
            deckSize -= 1;
            return TheDeck[dealIndex++];   
        }
    }
}
