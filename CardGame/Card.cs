using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public enum House
    {
        Spade,
        Club,
        Diamond,
        Heart
    }

    public class Card
    {
        private Card(House house, string? value, string? colour)
        {
            this.house = house;
            this.value = value;
            this.colour = colour;
            //this.spritePath = spritePath;
        }

        private House house { get; }
        private string? value { get; }
        private string? colour { get; }
        private string? spritePath { get; set; }

        public void printCard()
        {
            Console.WriteLine($"House:{this.house}\n" +
                $"Value:{this.value}\n" +
                $"Colour:{this.colour}\n");
        }
    }
}