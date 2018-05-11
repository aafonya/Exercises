using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Game newGame = new Game();
            Player.MaxCardToGetOnce = 10;
            Player.MaxCardToHold = 20;
            newGame.AddPlayer("Johnny");
            newGame.AddPlayer("Paul");
            newGame.AddPlayer("George");
            newGame.AddPlayer("Ringo");
            newGame.Deal();
            Player winner = newGame.GetWinner();
            while (Console.ReadKey().Key != ConsoleKey.Escape) 
            {
                if(Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    newGame.Deck = new Deck();
                    newGame.Deal();
                    winner = newGame.GetWinner();
                    Console.WriteLine(newGame.AllData());
                    Console.WriteLine(winner.Name);
                }
            }
        }
    }
}
