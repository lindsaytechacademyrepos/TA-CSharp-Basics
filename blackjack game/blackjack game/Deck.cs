using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack_game
{
    public class Deck
    {
        //put any constructors at the top, before the properties
        //constructors are ways of assigning default values to any new object created, and constructor names are always the same as the class
        public Deck()
        {
            //first create a list of all possible suits and faces

            Cards = new List<Card>(); //Cards refers to a property of the class we're in, which is why we don't have to do anything before Cards. essentially, as soon as a new deck is created, a list of cards will be created
            
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two","Three","Four","Five","Six","Seven",
                "Eight","Nine","Ten","Jack","Queen", "King"
            };

            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card(); //for each suit and face, we want to first instatiate a new card
                    card.Suit = suit; //then assign that cards Suit property the value from variable suit
                    card.Face = face; //then assign the card's Face property the value from variable face
                    Cards.Add(card);
                }
            }
        }
        
        //setting the property of DECK
        public List<Card> Cards { get; set; }   //template for creating an empty list of Card objects
    }
}
