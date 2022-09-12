using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using RS_HelperLibrary;

namespace CardGame
{
    public class Deck
    {
        private List<Card>? theDeck { get; }
        private HelperClass? theHelper_;

        //A constuctor to avoid the null reference of the Deck Object when called within the fromitself
        public Deck()
        {
            theDeck = new List<Card>();
            theHelper_ = new HelperClass();
        }

        /*
         * Method Name: addCard
         * Method Purpose: Adds A Card to the Deck
         * Method Parms: Card(Card)
         */

        public void addCard(Card? aCard_)
        {
            theDeck?.Add(aCard_);
        }//end addCard

        /*
         * Method Name: shuffleDeck
         * Method Purpose: Shuffles the deck
         */

        public void shuffleDeck()
        {
            for (int i = 0; i < 209; i++) //Statitically Allows all cards to move 4 times
            {
                int aRandomCardIndex = theHelper_.getRandomNumBetween(0, 51);
                Card? aCardCopy;
                aCardCopy = theDeck?.ElementAt(aRandomCardIndex);
                theDeck?.Remove(aCardCopy);
                theDeck?.Add(aCardCopy);
            }
        }//end shuffle

        /*
         * Method Name: createDeck
         * Method Purpose: Creates the deck
         */

        public void createDeck()
        {
            //Create Per Suit
            for (int house = 0; house < 4; house++)
            {
                for (int value = 1; value < 14; value++)
                {
                    Card aCard = new Card(house, value);
                    addCard(aCard);
                }//end for value
            }//end for house
        }

        /*
         * Method Name: resetDeck
         * Method Purpose: Resets the deck
         */

        public void resetDeck()
        {
            theDeck.Clear();
            createDeck();
            shuffleDeck();
        }

        /*
         * Method Name: getSize
         * Method Purpose: return size of the List
         */

        public int getSize()
        {
            return theDeck.Count();
        }//end getSize()

        /*
         * Method Name: getElement
         * Method Purpose: return card from deck at given index
         * Method Parmas: Index(int)
         */

        public Card getElement(int i)
        {
            return theDeck.ElementAt(i);
        }//end getElement
    }
}