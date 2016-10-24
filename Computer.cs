using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    public class Computer : Game

    {
        string player;
        string computer;
        int round;
        
        public Computer(string player, string computer, int round)
        {
            this.computer;
            this.player;
            this.round;

        }
        public string PickOption()
        {
            Console.WriteLine("Pick Rock, Paper, Scissors, Lizard, or Spock");
            string response = Console.ReadLine();
            return response;
        }
        public void Addoption(string userResponse)
        {
            option.Add(userResponse);
        }
        public string Computer()
        {
            Random rnd = new Random();
            string option = rnd.Next(rock, paper, scissors, lizard, spock);

        }

    }
}
