using Newtonsoft.Json;
using System;

namespace Cards_Game
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var json = JsonConvert.SerializeObject(new Card("d", "h", true));
        }
    }

}