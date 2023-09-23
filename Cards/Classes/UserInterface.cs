using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards.Classes
{
    public class UserInterface
    {
        public void Run()
        {
            bool isDone = false;
            Deck deck = new Deck();

            while (!isDone)
            {
                DisplayMenu();
                int userInput = Convert.ToInt32(Console.ReadLine());

                switch(userInput)
                {
                    case 1:
                        deck.Shuffle();
                        break;
                    case 2:
                        deck.DealCard();
                        break;
                    case 3:
                        DisplayGamesMenu();
                        break;
                    default:
                        Console.WriteLine("Please select a valid option from the menu.");
                        DisplayMenu();
                        break;
                }

                isDone = true;
            }
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Welcome to the Card Games App!");
            Console.WriteLine("Please select what you'd like to do: ");
            Console.WriteLine("(1) Shuffle deck");
            Console.WriteLine("(2) Deal deck");
            Console.WriteLine("(3) Choose a game");
        }

        public void DisplayGamesMenu()
        {
            Console.WriteLine("What game would you like to play?");
            Console.WriteLine("(1) Euchre");
            Console.WriteLine("(2) Blackjack");
            Console.WriteLine("(3) Solitaire");
        }

    }
}
