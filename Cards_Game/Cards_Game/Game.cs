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
        private int player_count = 0;

        public Game(int _player_count)
        {
            player_count= _player_count;
            add_players();
            for(var i = 0; i < players_list.Count; i++)
            {
                try
                {
                    players_list[i].attack();
                    players_list[i + 1].deffend();
                }
                catch(Exception e)
                {
                    players_list[1].deffend();
                }
            }
        }

        public void add_players()
        {
            for(var i = 0; i < player_count; i++)
            {
                players_list.Add(new Player());
            }
        }
    }
}
