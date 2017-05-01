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
        public int Id { get; set; }

        /// <summary>
        /// Card value, runs 2-14. Jack = 11, Queen = 12, King = 13, Ace = 14
        /// Card value may also run from 1-13, with ace coming in at the bottom.
        /// </summary>
        [JsonProperty("value")]
        public int Value { get; set; }

        /// <summary>
        /// Club, Heart, Spade, Diamond.
        /// </summary>
        [JsonProperty("suit")]
        public string Suit { get; set; }

        /// <summary>
        /// String representation of the card. Either the number or the name
        /// of the face card.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Image resource for the card. Should be the local path on disk.
        /// </summary>
        [JsonProperty("img")]
        public string Img { get; set; }
    }
}
