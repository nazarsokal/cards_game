﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards_Game
{
    public class Player
    {
        public List<Card> ListCards = new List<Card>();

        public string Name { get; set; }

        public bool isTook = false;

        public Player(string name)
        {
            Name = name;
        }

        public List<Card> attack()
        {
            List<Card> CardsList_From_User = new List<Card>();
            PrintPlayersCards(ListCards);
            var iter = 0;
            while(true)
            {
                Console.WriteLine("Choose cards to attack(enter number) \n Enter 'f' if you want to finish choosing cards ");
                var card_from_user = Console.ReadLine();
                try
                {
                    if(card_from_user == "f" && CardsList_From_User.Count != 0)
                    {
                        for(var i = 0; i < CardsList_From_User.Count; i++)
                        {
                            ListCards.Remove(CardsList_From_User[i]);
                        }
                        return CardsList_From_User;
                    }
                    else if(card_from_user != "f")
                    {
                        if(CardsList_From_User.Count >= 1)
                        {
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
        }

        public List<Card> deffend(List<Card> attacked_list) 
        {
            Console.WriteLine("You are attacked by this cards:");
            PrintPlayersCards(attacked_list);
            List<Card> defended_cards = new List<Card>();

            while (true)
            {
                if (attacked_list.Count == 0)
                {
                    return defended_cards;
                }
                else
                {
                    Console.WriteLine("To deffend choose a number of card. \n To finish defending choose 'f' or 't' to take cards \n Your cards: ");
                    PrintPlayersCards(ListCards);

                    Console.WriteLine("count: " + attacked_list.Count);
                    var card_from_user = Console.ReadLine();
                    if (card_from_user == "t")
                    {
                        for(var i = 0; i < attacked_list.Count; i++)
                        {
                            ListCards.Add(attacked_list[i]);
                        }
                        isTook = true;
                        break;
                    }
                    else
                    {
                        var canBeRemoved = false;

                        for (var i = 0; i < attacked_list.Count; i++)
                        {
                            if (ListCards[Convert.ToInt32(card_from_user)].Suit == attacked_list[i].Suit &&
                                ListCards[Convert.ToInt32(card_from_user)].worth > attacked_list[i].worth)
                            {
                                canBeRemoved = true;
                                defended_cards.Add(ListCards[Convert.ToInt32(card_from_user)]);
                                attacked_list.RemoveAt(i);
                                ListCards.RemoveAt(Convert.ToInt32(card_from_user));
                                isTook = false;
                            }
                            else if (ListCards[Convert.ToInt32(card_from_user)].IsTrump && attacked_list[i].IsTrump == false)
                            {
                                canBeRemoved = true;
                                defended_cards.Add(ListCards[Convert.ToInt32(card_from_user)]);
                                attacked_list.RemoveAt(i);
                                ListCards.RemoveAt(Convert.ToInt32(card_from_user));
                                isTook = false;
                            }
                            /*else
                            {
                                Console.WriteLine("Bad!!");
                            }*/
                        }
                        if (canBeRemoved == false)
                        {
                            Console.WriteLine("You cannot beat a card with another suit or less worth");
                        }
                    }
                }
            }
            return null;
        }

        public void PrintPlayersCards(List<Card> cards)
        {
            var i = 0;
            foreach (var card in cards)
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
