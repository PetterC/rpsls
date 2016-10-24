using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    public class Human
    {
       
            string name;
            string choice;
        
        public Human(string name, string choice)
        {
            this.name = name;
            this.choice = choices;
        }
        public string GetPlayerChoices()
        {
            Console.WriteLine("Please Enter Your Name");
            string respond = Console.ReadLine();
            return respond;
        }
        public void AddChoice(string userRespond)
        {
            choice.Add(userRespond);
        }
    }
    }

