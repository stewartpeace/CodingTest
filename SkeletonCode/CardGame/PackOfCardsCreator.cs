using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkeletonCode.CardGame
{
	public class PackOfCardsCreator : IPackOfCardsCreator
	{
        PackOrCards _PackOfCards = new PackOrCards();

		public IPackOfCards Create()
		{

            _PackOfCards.AddRange(CreateSuite(Suit.Clubs));
            _PackOfCards.AddRange(CreateSuite(Suit.Diamonds));
            _PackOfCards.AddRange(CreateSuite(Suit.Hearts));
            _PackOfCards.AddRange(CreateSuite(Suit.Spades));

            return _PackOfCards;
        }

        private List<ICard> CreateSuite(Suit suit)
        {
            List<ICard> cards = new List<ICard>();

            foreach (CardNum card in Enum.GetValues(typeof(CardNum)))
            {
                cards.Add(new Card(suit, card));
            }

            return cards;
        }
	}
}
