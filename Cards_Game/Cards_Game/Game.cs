using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards_Game
{
    public class Game
    {
        public static List<Player> players_list = new List<Player>();
        public static List<Card> cards_list = new List<Card>();
        private int player_count = 0;

        public Game(int _player_count)
        {
            cards_list = Deck.Generate();
            player_count= _player_count;
            Add_players();
            DivideCardsByPlayers();
            /*for(var i = 0; i < players_list.Count; i++)
            {
                try
                {
                    players_list[i].attack();
                    players_list[i + 1].deffend();

                }
                catch(Exception e)
                {
                    players_list[0].deffend();
                    //i = 0;
                }
            }*/
        }

        public void DivideCardsByPlayers()
        {
            int num = 0;
            for (var i = 0; i < players_list.Count; i++)
            {
                while(players_list[i].GetListCards().Count != 6)
                {
                    players_list[i].setListCards(cards_list[num]);
                    Remove_Cards(cards_list[num]);
                    num++;
                }
                num = 0;
            }
        }

        public void Add_players()
        {            
            for(var i = 0; i < player_count; i++)
            {
                players_list.Add(new Player());
            }
        }

        public void Remove_Cards(Card card)
        {
            cards_list.Remove(card);
        }

        public List<Player> GetPlayers()
        {
            return players_list;
        }

        public List<Card> GetCards()
        {
            return cards_list;
        }
    }
}
