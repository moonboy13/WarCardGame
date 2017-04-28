﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameWar
{
    /// <summary>
    /// Contain all information for an individual player.
    /// </summary>
    class Player
    {
        /// <param name="name">The name of the player</param>
        private string name;

        /// <summary>
        /// Get the players name
        /// </summary>
        /// <returns>The player name</returns>
        private string GetName()
        {
            return name;
        }

        /// <summary>
        /// Set the current players name
        /// </summary>
        /// <param name="value">Player Name</param>
        private void SetName(string value)
        {
            name = value;
        }

        /// <summary>
        /// The cards in the players hand. The 0'th element represents the bottom
        /// card in the player's deck.
        /// </summary>
        private List<Card> hand;

        /// <summary>
        /// Insert a singular card at the bottom of the deck.
        /// </summary>
        /// <param name="newCard">Card to add into the deck.</param>
        public void AddCard(Card newCard)
        {
            hand.Insert(0, newCard);
        }

        /// <summary>
        /// Add in a range of cards to the bottom of the deck.
        /// </summary>
        /// <param name="newCards">List of new cards to add in.</param>
        public void AddMultipleCards(List<Card> newCards)
        {
            hand.InsertRange(0, newCards);
        }

        /// <summary>
        /// Pop the top card of the player's deck off.
        /// </summary>
        /// <returns>Top card for the player.</returns>
        public Card GetTopCard()
        {
            Card returnCard = hand.ElementAt(hand.Count - 1);
            hand.RemoveAt(hand.Count - 1);
            return returnCard;
        }
    }
}
