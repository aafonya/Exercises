using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailRace
{
    class Race
    {
        public List<Snail> racers;
        readonly int finish;
        private int time;

        public int Time
        {
            get { return time; }
            set { if (value > 0) { time = value; } }
        }

        Snail Winner { get; set; }

        public Race(int numberOfRacers, int finish)
        {
            racers = new List<Snail>(numberOfRacers);
            this.finish = finish;
            this.time = 0;
            this.Winner = null;
        }

        public void AddRacer(Snail racerSnail)
        {
            racers.Add(racerSnail);
        }

        public void UpdateTime(int dt)
        {
            if(dt > 0)
            {
                Time += dt;
            }
        }

        public void UpdateRacers()
        {
            foreach(Snail racer in racers)
            {
                racer.UpdatePosition();
            }
        }

        public void UpdateWinner()
        {
            var orderedPosition = from racsn in racers
                      orderby racsn.Position ascending
                      select racsn.Position;

            var max = orderedPosition.Last();
            var winnerSnails = from racersnail in racers where (racersnail.Position) == (max) select racersnail;

            Winner = winnerSnails.First();
        }

        public bool IsOver()
        {
            var orderedPosition = from racsn in racers
                                  orderby racsn.Position ascending
                                  select racsn.Position;

            var max = orderedPosition.Last();

            if(max == finish | max > finish)
            {
                return true;
            }
            return false;
        }

        public void ShowResult()
        {
            Console.Clear();
            Console.WriteLine("Time: {0}", Time);
            foreach(Snail snaily in racers)
            {
                Console.WriteLine(snaily.ToString());
            }
            Console.WriteLine("Current Winner: {0}", Winner);
        }
    }
}
