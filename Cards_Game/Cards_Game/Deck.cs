using System;
namespace Cards_Game
{
	public static class Deck
	{
        static List<Card> cards_list = new List<Card>();
        static List<string> card_symbols = new List<string>() { "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        static List<string> suit_symbols = new List<string>() { "♠", "♣", "♥", "♦" };
        public static List<Card> Generate()
		{

			Random random = new Random();
			var r = random.Next(suit_symbols.Count);

            for (var i = 0; i < 4; i++)
			{
				for(var j = 0; j < 9; j++)
				{
					if(r == i)
					{
                        cards_list.Add(new Card(suit_symbols[i], card_symbols[j], true));
                    }
					else
					{
                        cards_list.Add(new Card(suit_symbols[i], card_symbols[j], false));
                    }

				}
			}

			return cards_list;
		}
		public static void RemoveCards(Card card)
		{
			cards_list.Remove(card);
		}
	}
}

