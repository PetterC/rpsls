using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    class Player : Game

    {
        string playerOne;
        string playerTwo;
        int round;


        public Player(string playerOne, string playertwo, int round)
        {
            this.playerOne = playerOne;
            this.playertwo = playerTwo;
            this.round = round;
            
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

    }
    }

