using System;

namespace Cards_Game
{
	public class Card
	{
		public string Suit { get; private set; }

		public string Symbol { get; private set; }

		public int worth = 0;

		public bool IsTrump { get; private set; }

		public Card(string suit, string symbol, bool isTrump, int _worth)
		{
			Suit = suit;
			Symbol = symbol;
			IsTrump = isTrump;
			worth = _worth;
		}
	}
}

