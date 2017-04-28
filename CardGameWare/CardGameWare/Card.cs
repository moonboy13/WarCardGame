using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameWar
{
    // <summary>
    // Representation of a playing card in the game.
    // </summary>
    class Card
    {
        /// <summary>
        /// The identification number for the card, 1-52
        /// </summary>
        private int id;

        public int GetId()
        {
            return id;
        }

        public void SetId(int value)
        {
            id = value;
        }

        /// <summary>
        /// Card value, runs 2-14. Jack = 11, Queen = 12, King = 13, Ace = 14
        /// Card value may also run from 1-13, with ace coming in at the bottom.
        /// </summary>
        private int value;

        public int GetValue()
        {
            return value;
        }

        public void SetValue(int value)
        {
            this.value = value;
        }

        /// <summary>
        /// Club, Heart, Spade, Diamond.
        /// </summary>
        private string suit;

        public string GetSuit()
        {
            return suit;
        }

        public void SetSuit(string value)
        {
            suit = value;
        }

        /// <summary>
        /// String representation of the card. Either the number or the name
        /// of the face card.
        /// </summary>
        private string name;

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        /// <summary>
        /// Image resource for the card. Should be the local path on disk.
        /// </summary>
        private string img;

        public string GetImg()
        {
            return img;
        }

        public void SetImg(string value)
        {
            img = value;
        }
    }
}
