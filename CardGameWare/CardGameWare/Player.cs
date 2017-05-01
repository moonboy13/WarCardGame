using System;
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
        /// <summary>
        /// The name of the player
        /// </summary>
        private string name;

        /// <summary>
        /// The cards in the players hand. The 0'th element represents the bottom
        /// card in the player's deck.
        /// </summary>
        private List<Card> hand;

        /// <summary>
        /// UI element for the players card count so that it can be updated.
        /// </summary>
        private System.Windows.Forms.Label playerCardCountBox;

        /// <summary>
        /// UI element to display the user's current face-up card.
        /// </summary>
        private System.Windows.Forms.PictureBox playerCardPictureBox;

        public Player()
        {
            this.name = "";
            this.hand = new List<Card>();
        }
        public Player(string name)
        {
            this.name = name;
            this.hand = new List<Card>();
        }
        public Player(string name, System.Windows.Forms.PictureBox CardPictureBox, System.Windows.Forms.Label cardCount)
        {
            this.name = name;
            this.hand = new List<Card>();
            this.playerCardPictureBox = CardPictureBox;
            playerCardCountBox = cardCount;
        }

        /// <summary>
        /// Update the path for the user's card.
        /// </summary>
        /// <param name="path">Relative path to image asset.</param>
        public void SetPicturePath(string path)
        {
            this.playerCardPictureBox.ImageLocation = path;
        }

        /// <summary>
        /// Get the players name
        /// </summary>
        /// <returns>The player name</returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// Set the current players name
        /// </summary>
        /// <param name="value">Player Name</param>
        public void SetName(string value)
        {
            name = value;
        }

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
        /// Update the count of the players cards in their hand
        /// </summary>
        public void UpdateCardCount()
        {
            playerCardCountBox.Text = hand.Count.ToString();
        }

        /// <summary>
        /// Pop the top card of the player's deck off.
        /// </summary>
        /// <returns>Top card for the player.</returns>
        public Card GetTopCard()
        {
            if (hand.Count == 0)
            {
                throw new PlayerOutOfCardsException(this.name + " has no more cards.");
            }
            else
            {
                Card returnCard = hand.ElementAt(hand.Count - 1);
                hand.RemoveAt(hand.Count - 1);
                return returnCard;
            }
        }
    }
}
