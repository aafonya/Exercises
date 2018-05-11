using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();

            foreach(var suit in Enum.GetNames(typeof(Suit.SuitEnum)))
            {
                foreach(var rank in Enum.GetNames(typeof(Rank.RankEnum)))
                {
                    Cards.Add(new Card(suit, rank));
                }
            }
        }
        static Random rnd = new Random();

        List<Card> Cards;

        private int cardNum;

        public int CardCounter
        {
            get { return Cards.Count; }
            private set { cardNum = value; }
        }


        public Card TopCard()
        {
            return Cards.Last();
        }

        public bool RemoveTopCard()
        {
            if(CardCounter != 0)
            {
                Cards.Remove(TopCard());
                return true;
            }
            return false;
        }


        public string AllData()
        {
            StringBuilder sb = new StringBuilder();

            foreach(Card cardy in Cards)
            {
                sb.Append(cardy.AllData() + "\n");
            }

            return sb.ToString();
        }

        private void ExchangeCards(int change, int change2)
        {
            if (change == 51 | change2 == 51)
            {
                Console.WriteLine("51 is changed");
            }
            Card tempCard = Cards[change];
            Cards[change] = Cards[change2];
            Cards[change2] = tempCard;
        }

        public void Shuffle(int shuffleCounter)
        {            
            for(int i = 0; i < shuffleCounter; i++)
            {
                ExchangeCards(rnd.Next(0, Cards.Count), rnd.Next(0, Cards.Count));
            }
        }
    }
}
