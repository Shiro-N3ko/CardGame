using RS_HelperLibrary;

namespace CardGame
{
    public class Player
    {
        private List<Card> playerHand { get; }
        private HelperClass theHelperClass;

        //Contructor To prevent Null Reference Error
        public Player()
        {
            playerHand = new List<Card>();
            theHelperClass = new HelperClass();
        }

        public void addToPlayerHand(Card aCard_)
        {
            playerHand.Add(aCard_);
        }
    }
}