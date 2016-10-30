using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkeletonCode.CardGame
{

    public class Card : ICard
    {
        Suit _Suit = Suit.Clubs;
        CardNum _CardNumber = CardNum.Two;

        public Card(Suit suit, CardNum cardNum)
        {
            _Suit = suit;
            _CardNumber = cardNum;
        }

        public Suit Suit { get { return _Suit; } }
        public CardNum CardNumber { get { return _CardNumber; } }

        public override string ToString()
        {
            if ((int)CardNumber > 1 && (int)CardNumber < 11)
                return ((int)CardNumber).ToString();
            else return CardNumber.ToString();

              
        }
    }
}
