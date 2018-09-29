using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack_game
{
    public class Card 
    {
       //values assigned to an object upon creation
       //public Card()
       // {
       //     Suit = "Spades";
       //     Face = "Two";
       // }
        
        
        //give card class a PROPERTY called suit
        //setting the class and property as "public" makes it accessible to the rest of the program

        public string Suit { get; set; } //the card class has a property of data type string called suit, and you can either GET or SET this property
        public string Face { get; set; } 

        //a class is just a model/design for an object. so when we assign a suit we're not assigning a value to the class. later on we'll give the value "suit" to an OBJECT that is *modeled* on the class we're creating
    }
}
