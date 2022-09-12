﻿using RS_HelperLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame
{
    public partial class formCardGame : Form
    {
        public Deck theDeck = new Deck();
        public HelperClass? theHelper;

        public formCardGame()
        {
            InitializeComponent();
        }

        private void createDeckBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 51; i++)
            {
                //Within Suite
            }
        }

        private void shuffleBtn_Click(object sender, EventArgs e)
        {
            theDeck.shuffle();
            for (int i = 0; i < theDeck.getSize(); i++)
            {
                theDeck.getElement(i).printCard();
            }//end for DeckSize
        }//end ClickShuffle
    }
}