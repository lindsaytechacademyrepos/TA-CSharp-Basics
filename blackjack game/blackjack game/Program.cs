using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack_game
{
    class Program
    {
        static void Main(string[] args)
        {
            //objects are the backbone of object oriented programming. 
            //technology basics dictionary
            //objects are items that can be represented by a computer program. often meant to represent
            //real world things.
            //objects have STATES and BEHAVIOR
            //State is size, color, etc at any point in time.
            //Video 1 deals with states. Going to create classes and give classes properties

            //first thing is to create a card class. Right click --> add --> class, name the class
            //video 2 creating a card object:

            //Card cardOne = new Card(); // an object of data type Card, assigned to the variable cardOne. We instatiated an object, but its properties are currently empty;

            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";

            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);

            Deck deck = new Deck(); //instantiating an empty object called deck, which is a list
            deck = Shuffle(deck); //calls the method we created below and automatically shuffles the deck as soon as it's called

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }


            Console.ReadLine();         

        
        }
        //Methods video creating a method
        public static Deck Shuffle(Deck deck)
        { 
            List<Card> TempList = new List<Card>(); //instatiates a placeholder deck
            Random random = new Random(); //instatiates a new random object

            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count); //creates a random number between 0 and the number of cards remaining in the original deck
                TempList.Add(deck.Cards[randomIndex]); //takes the card at the random index from the original deck and adds it to the temp deck
                deck.Cards.RemoveAt(randomIndex); //removes the card at that index from the original deck
            }

            deck.Cards = TempList; //takes the placeholder deck and makes it the official deck
            return deck;
        }
    }
}
