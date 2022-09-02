using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public enum house
    {
        Spade,
        Club,
        Diamond,
        Heart
    }

    public class Card
    {
        private Card(house house, string? value, string? colour)
        {
            this.house = house;
            this.value = value;
            this.colour = colour;
            //this.spritePath = spritePath;
        }

        private house house { get; }
        private string? value { get; }
        private string? colour { get; }
        private string? spritePath { get; set; }
    }
}