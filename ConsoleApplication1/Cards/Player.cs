using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    class Player
    {
        public Player()
        {
            Cards = new List<Card>();
        }

        public Player(string name) : this()
        {
            Name = name;
        }
        public string Name { get; set; }

        public static int MaxCardToGetOnce { get; set; }

        public static int MaxCardToHold { get; set; }

        List<Card> Cards;

        public bool AddCard(Card newCard)
        {
            if(Cards.Count + 1 <= MaxCardToHold)
            {
                Cards.Add(newCard);
                return true;
            }
            return false;
        }

        public int SumValues()
        {
            return  Cards.Sum(item => item.GetValue());
        }

        public string AllData()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Player: " + Name + " ");

            foreach (Card cardy in Cards)
            {
                sb.Append(cardy.AllData() + "\n");
            }

            return sb.ToString();
        }
    }
}
