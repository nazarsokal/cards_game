using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards_Game
{
    public class Bot : IPlayer
    {
        /*public List<Card> ListCards = new List<Card>();

        public string Name { get; }

        public bool isTook = false;*/

        public string Name { get; private set; }

        public Bot(string name) : base(name)
        {
            Name = name;
        }

        public override List<Card> attack()
        {
            Console.WriteLine($"Bot {Name} attacks");
            return null;
        }

        public override List<Card> defend(List<Card> attacked_list)
        {
            Console.WriteLine($"Bot {Name} defends");
            return null;
        }

        public override List<Card> throwUpCards(List<Card> attacked_cards, List<Card> defended_cards, string name)
        {
            Console.WriteLine($"Bot {Name} throw up cards");
            return null;
        }

        public override void PrintPlayersCards(List<Card> cards)
        {
            var i = 0;
            foreach (var card in cards)
            {
                Console.WriteLine($"{i}: {card.Symbol}{card.Suit} {card.IsTrump}");
                i++;
            }
        }

        public override void setListCards(Card card)
        {
            ListCards.Add(card);
        }

        public override List<Card> GetListCards()
        {
            return ListCards;
        }
    }
}
