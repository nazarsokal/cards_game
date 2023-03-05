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

        public List<Card> attack()
        {
            List<Card> CardsList_From_User = new List<Card>();
            PrintPlayersCards();
            var iter = 0;
            while(true)
            {
                Console.WriteLine("Choose cards to attack(enter number) \n Enter 'f' if you want to finish choosing cards ");
                var card_from_user = Console.ReadLine();
                try
                {
                    if(card_from_user == "f" && CardsList_From_User.Count != 0)
                    {
                        return CardsList_From_User;
                    }
                    else if(card_from_user != "f")
                    {
                        if(CardsList_From_User.Count >= 1)
                        {
                            //CardsList_From_User[iter--].Symbol
                            Console.WriteLine("Size: " + CardsList_From_User.Count);
                            Console.WriteLine("Number: " + (iter - 1));
                            if (ListCards[Convert.ToInt32(card_from_user)].Symbol == CardsList_From_User[iter-1].Symbol)
                            {
                                CardsList_From_User.Add(ListCards[Convert.ToInt32(card_from_user)]);
                            }
                            else
                            {
                                Console.WriteLine("You cannot choose cards with different symbols");
                                iter = iter - 1;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Your choice: {ListCards[Convert.ToInt32(card_from_user)].Symbol}{ListCards[Convert.ToInt32(card_from_user)].Suit}");
                            CardsList_From_User.Add(ListCards[Convert.ToInt32(card_from_user)]);
                        }
                    }
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                iter++;
            }
            return null;
        }

        public void deffend() 
        {
            Console.WriteLine("Defend");
            Console.WriteLine();
        }

        public void PrintPlayersCards()
        {
            var i = 0;
            foreach (var card in ListCards)
            {
                Console.WriteLine($"{i}: {card.Symbol}{card.Suit} {card.IsTrump}");
                i++;
            }
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
