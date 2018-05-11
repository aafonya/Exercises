using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailRace
{
    public class Snail
    {
        public static Random RndGen = new Random();
        public string Name { get; private set; }
        public int Position
        {
            get { return Position; }
            set { if (value > Position ) { Position = value; } }
        }
        private int velocity;

        public int Velocity
        {
            get { return velocity; }
            private set { if (value >= 0) { velocity = value; } }
        }

        public Snail(string name, int velocity)
        {
            Name = name;
            Velocity = velocity;
        }

        int GenerateVelocity()
        {
            int vel = Math.Max(RndGen.Next(Velocity - 2, Velocity + 3), 0);
            return vel;
        }
        
        public void UpdatePosition()
        {
            Position += GenerateVelocity();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("|");
            for(int i = 0; i < Position; i++)
            {
                sb.Append("-");
            }
            sb.Append("X" + Name);
            return sb.ToString();
        }
    }
}
