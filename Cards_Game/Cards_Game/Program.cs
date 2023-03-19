using Newtonsoft.Json;
using System;
using System.Reflection.Metadata.Ecma335;

namespace Cards_Game
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Game game = new Game(3);
            /*foreach (var k in game.GetPlayers())
            {
                foreach(var j in k.GetListCards())
                {
                    Console.WriteLine($"{j.Symbol} {j.Suit} {j.IsTrump}");
                }
                Console.WriteLine();
            }*/
            
        }
    }

}

/*
 *             var i = 1;
            foreach (var j in game.GetCards())
            {
                Console.WriteLine($"{j.Symbol} {j.Suit} {j.IsTrump} {i}");
                i++;
            }
            }
            */