using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    class Game
    {
        public Game()
        {
            Deck = new Deck();
            Players = new List<Player>();
        }

        public Deck Deck;

        public List<Player> Players;

        public void AddPlayer(string name)
        {
            Players.Add(new Player(name));
        }

        public bool Deal()
        {
            if(Deck.CardCounter >= Players.Count)
            {
                Deck.Shuffle(Deck.CardCounter);
                foreach (Player player in Players)
                {
                    player.AddCard(Deck.TopCard());
                    Deck.RemoveTopCard();
                }
                return true;
            }
            return false;            
        }

        public Player GetWinner()
        {
            int max = Players.Max(player => player.SumValues());
            var winner = from player in Players where ((player.SumValues()) == max) select player;
            if(winner.Count() > 1)
            {
                Console.WriteLine("We have more winners");
            }
            return winner.First();         
        }

        public string AllData()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Player player in Players)
            {
                sb.Append(player.AllData() + "\n");
            }

            return sb.ToString();
        }
    }
}
