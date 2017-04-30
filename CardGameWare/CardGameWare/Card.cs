using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
        [JsonProperty("id")]
        private int id;

        /// <summary>
        /// Card value, runs 2-14. Jack = 11, Queen = 12, King = 13, Ace = 14
        /// Card value may also run from 1-13, with ace coming in at the bottom.
        /// </summary>
        [JsonProperty("value")]
        private int value;

        /// <summary>
        /// Club, Heart, Spade, Diamond.
        /// </summary>
        [JsonProperty("suit")]
        private string suit;

        /// <summary>
        /// String representation of the card. Either the number or the name
        /// of the face card.
        /// </summary>
        [JsonProperty("name")]
        private string name;

        /// <summary>
        /// Image resource for the card. Should be the local path on disk.
        /// </summary>
        [JsonProperty("img")]
        private string img;

        public int GetId()
        {
            return id;
        }

        public void SetId(int value)
        {
            id = value;
        }

        public int GetValue()
        {
            return value;
        }

        public void SetValue(int value)
        {
            this.value = value;
        }

        public string GetSuit()
        {
            return suit;
        }

        public void SetSuit(string value)
        {
            suit = value;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

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
