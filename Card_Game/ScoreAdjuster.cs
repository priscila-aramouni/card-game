using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Card_Game
{
    class ScoreAdjuster
    {
        public void LosePoints(Player player)
        {
            NumberCard _card = player.dealtCard as NumberCard;

            if (_card.value < 5)
            {
                player.scoreDifference = -2;
                player.score -= 2;
            }
            else
            {
                player.scoreDifference = -1;
                player.score -= 1;
            }
        }

        public void WinPoints(Player player)
        {
            NumberCard _card = player.dealtCard as NumberCard;

            if (_card.value < 5)
            {
                player.scoreDifference = +1;
                player.score += 1;
            }
            else
            {
                player.scoreDifference = +2;
                player.score += 2;
            }
        }

        public void AdjustScore(Player _player)
        {
            switch (_player.type)
            {
                /************* BLACK PLAYER *************/
                case "Black":
                    if (_player.dealtCard.isNumberCard() && _player.dealtCard.isBlackCard())
                    {
                        WinPoints(_player);
                    }
                    else if (_player.dealtCard.isNumberCard() && _player.dealtCard.isRedCard())
                    {
                        LosePoints(_player);
                    }
                    else
                    {
                        _player.scoreDifference = -2;
                        _player.score -= 2;
                    }
                    break;

                /************* RED PLAYER *************/
                case "Red":
                    if (_player.dealtCard.isNumberCard() && _player.dealtCard.isBlackCard())
                    {
                        LosePoints(_player);
                    }
                    else if (_player.dealtCard.isNumberCard() && _player.dealtCard.isRedCard())
                    {
                        WinPoints(_player);
                    }
                    else
                    {
                        _player.scoreDifference = -2;
                        _player.score -= 2;
                    }
                    break;

                /************* PICTURE PLAYER *************/
                case "Picture":
                    if (_player.dealtCard.isNumberCard() && _player.dealtCard.isBlackCard())
                    {
                        LosePoints(_player);
                    }
                    else if (_player.dealtCard.isNumberCard() && _player.dealtCard.isRedCard())
                    {
                        LosePoints(_player);
                    }
                    else
                    {
                        _player.scoreDifference = +2;
                        _player.score += 2;
                    }
                    break;
            }
        }
    }
}
