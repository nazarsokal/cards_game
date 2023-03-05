using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards_Game
{
    public class Player
    {
        public List<Card> ListCards = new List<Card>();

        public void attack()
        {
            Console.WriteLine("Attack");
        }

        public void deffend() 
        {
            Console.WriteLine("Defend");
            Console.WriteLine();
        }

        public void setListCards(Card card)
        {
            ListCards.Add(card);
        }

        public List<Card> GetListCards()
        {
            return ListCards;
        }
    }
}
