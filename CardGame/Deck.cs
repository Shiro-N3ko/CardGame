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
        private List<Card?>? theDeck { get; }
        private HelperClass? theHelper_;

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
         * Method Name: shuffle
         * Method Purpose: Shuffles the deck
         */

        public void shuffle()
        {
            for (int i = 0; i < 209; i++) //Statitically Allows all cards to move 4 times
            {
                int aRandomCardIndex = theHelper_.getRandomNumBetween(1, 52);
                Card? aCardCopy;
                aCardCopy = theDeck?.ElementAt(aRandomCardIndex);
                theDeck?.Remove(aCardCopy);
                theDeck?.Add(aCardCopy);
            }
        }//end shuffle

        /*
         * Method Name:
         * Method Purpose:
         *
         */

        public int getSize()
        {
            return theDeck.Count();
        }//end getSize()

        public Card getElement(int i)
        {
            return theDeck.ElementAt(i);
        }
    }
}