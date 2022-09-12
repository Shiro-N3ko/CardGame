using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public enum House
    {
        Spade = 0,
        Club = 1,
        Diamond = 2,
        Heart = 3
    }

    public enum Value
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }

    public enum Colour
    {
        Black = 0,
        Red = 1
    }

    public class Card
    {
        private Card(House house, Value value, Colour colour)
        {
            this.house = house;
            this.value = value;
            this.colour = colour;
            //this.spritePath = spritePath;
        }

        private House house { get; }
        private Value value { get; }
        private Colour colour { get; }
        private string? spritePath { get; set; }

        public void printCard()
        {
            Console.WriteLine($"House:{this.house}\n" +
                $"Value:{this.value}\n" +
                $"Colour:{this.colour}\n");
        }
    }
}