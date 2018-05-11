using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailRace
{
    class Program
    {
        static void Main(string[] args)
        {
            Race snailRace = new Race(4, 50);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("added");
                Snail snail = new Snail("Player_" + i, 3);
                snailRace.AddRacer(snail);
                Console.WriteLine("added");
            }
        }
    }
}
