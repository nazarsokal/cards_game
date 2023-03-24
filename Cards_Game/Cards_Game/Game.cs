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
            var i = 0;
            while(players_list.Count != 1)
            {
                Console.WriteLine($"Player: {players_list[i].Name} attacks");
                List<Card> res = players_list[i].attack();
                List<Card> def_res;
                List<Player> buffer_player_list = new List<Player>();
                if(i == (players_list.Count - 1))
                {
                    Console.WriteLine($"Player: {players_list[0].Name} deffends");
                    def_res = players_list[0].deffend(res);
                    i = -1;
                }
                else
                {
                    Console.WriteLine($"Player: {players_list[i + 1].Name} deffends");
                    def_res = players_list[i + 1].deffend(res);

                    if (players_list[i + 1].isTook && (i + 1) != (players_list.Count - 1))
                    {
                        i++;
                    }
                    else if(players_list[i + 1].isTook && (i + 1) == (players_list.Count - 1))
                    {
                        i = -1;
                    }
                    else
                    {
                        List<Card> thrown_cards = new List<Card>();
                        List<Card> throw_res = new List<Card>();
                        buffer_player_list.AddRange(players_list);
                        buffer_player_list.RemoveAt(i + 1);

                        for(var j = 0; j <  buffer_player_list.Count; j++)
                        {
                            throw_res = buffer_player_list[j].throwUpCards(res, def_res, buffer_player_list[j].Name);
                            foreach (var item in throw_res)
                            {
                                thrown_cards.Add(item);
                            }
                        }

                        if(thrown_cards.Count != 0)
                            def_res = players_list[i + 1].deffend(thrown_cards);
                    }
                }

                if (cards_list.Count != 0)
                {
                    DivideCardsByPlayers();
                }
                i++;
            }
        }

        public void DivideCardsByPlayers()
        {
            int num = 0;
            for (var i = 0; i < players_list.Count; i++)
            {
                if(players_list[i].GetListCards().Count < 6)
                {
                    while (players_list[i].GetListCards().Count != 6)
                    {
                        players_list[i].setListCards(cards_list[num]);
                        Remove_Cards(cards_list[num]);
                        num++;
                    }
                    num = 0;
                }
            }
        }

        public void Add_players()
        {
            List<string> names = new List<string>() { "Roman", "Nazar", "Yurko", "Oleg", "Ashot"};
            for(var i = 0; i < player_count; i++)
            {
                players_list.Add(new Player(names[i]));
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
