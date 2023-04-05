using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards_Game
{
    public abstract class IPlayer
    {
        public List<Card> ListCards = new List<Card>();

        public string Name { get; }

        public bool isTook = false;

        public IPlayer(string name)
        {
            Name = name;
        }

        public abstract List<Card> attack();

        public abstract List<Card> defend(List<Card> attacked_list);

        public abstract List<Card> throwUpCards(List<Card> attacked_cards, List<Card> defended_cards, string name);

        public abstract void PrintPlayersCards(List<Card> cards);

        public abstract void setListCards(Card card);

        public abstract List<Card> GetListCards();
    }
}
