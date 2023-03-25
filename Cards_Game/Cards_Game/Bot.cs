using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards_Game
{
    public class Bot : Player
    {
        public Bot(string name) : base(name)
        {
            Name = name;
        }

        public List<Card> attack()
        {
            List<Card> CardsList_From_User = new List<Card>();
            PrintPlayersCards(ListCards);
            //ListCards = ListCards.OrderBy(x => x.worth).ToList();

            CardsList_From_User.Add((Card)card);

            foreach (var item in CardsList_From_User)
            {
                Console.WriteLine(item.Symbol + item.Suit + " " + item.IsTrump);
            }

            return CardsList_From_User;
        }

    }
}
