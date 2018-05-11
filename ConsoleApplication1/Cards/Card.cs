using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    class Card
    {
        public Card(string suit, string rank)
        {
            Suit = (Suit.SuitEnum)Enum.Parse(typeof(Suit.SuitEnum), suit);
            Rank = (Rank.RankEnum)Enum.Parse(typeof(Rank.RankEnum), rank);
        }
        public Suit.SuitEnum Suit { get; private set; }

        public Rank.RankEnum Rank { get; private set; }

        public string AllData()
        {
            StringBuilder data = new StringBuilder();
            data.Append(Suit.ToString() + " ");
            data.Append(Rank.ToString() + " ");
            return data.ToString();
        }

        public int GetValue()
        {
            return (int)Rank;
        }
    }
}
