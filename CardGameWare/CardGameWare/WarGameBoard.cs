using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace CardGameWar
{
    /// <summary>
    /// Main gameboard for the game of war.
    /// TODO: Consider creatinga a base, GameBoard class. To contain the generic
    /// functionality that would be shared amongst all card games.
    /// </summary>
    class WarGameBoard
    {
        /// <summary>
        /// Players involved in the game.
        /// </summary>
        private List<Player> gamePlayers;
        
        /// <summary>
        /// Deck of cards to play the game with.
        /// </summary>
        private List<Card> deck;
        
        /// <summary>
        /// Cards showing face up.
        /// </summary>
        private Dictionary<String, List<Card>> faceUpCards;
        
        /// <summary>
        /// Cards showing face down, these lists only occur during a war.
        /// </summary>
        private Dictionary<String, List<Card>> faceDownCards;

        /// <summary>
        /// Indication that a player has won. Tells outside processors the game is up.
        /// </summary>
        private Boolean playerWon = false;

        /// <summary>
        /// Wining player.
        /// </summary>
        private Player winner;

        /// <summary>
        /// Class constructor to initialize the game.
        /// </summary>
        /// <param name="players">Players involved</param>
        public WarGameBoard(List<Player> players)
        {
            // Initialize empty class variables
            gamePlayers = new List<Player>();
            deck = new List<Card>();
            faceUpCards = new Dictionary<string, List<Card>>();
            faceDownCards = new Dictionary<string, List<Card>>();

            gamePlayers = players;

            foreach (Player p in players)
            {
                faceUpCards[p.GetName()] = new List<Card>();
                faceDownCards[p.GetName()] = new List<Card>();
            }

            InitDeck();
            ShuffleDeck();
            DealDeck();
        }

        /// <summary>
        /// Read in the deck from the configuration file.
        /// </summary>
        private void InitDeck()
        {
            using (System.IO.StreamReader r = new System.IO.StreamReader("CardConfig/AceHighCardsConfig.json"))
            {
                string json = r.ReadToEnd();
                this.deck = JsonConvert.DeserializeObject<List<Card>>(json);
            }
        }

        /// <summary>
        /// Shuffle the deck of cards using Fisher-Yates suffle.
        /// </summary>
        private void ShuffleDeck()
        {
            Random rnd = new Random();
            int n = this.deck.Count();
            while (n > 1)
            {
                n--;
                int i = rnd.Next(n + 1);
                Card tmp = this.deck[i];
                this.deck[i] = this.deck[n];
                this.deck[n] = tmp;
            }
        }

        /// <summary>
        /// Split the deck between the two players. Emulate actual dealing instead of
        /// just spliting the list in half.
        /// </summary>
        private void DealDeck()
        {
            int counter = 1;
            foreach(Card c in this.deck)
            {
                this.gamePlayers[counter % 2].AddCard(c);
                counter++;
            }
        }

        /// <summary>
        /// Return if a player has won.
        /// </summary>
        /// <returns>Indicator if a player has won.</returns>
        public Boolean HasWinner()
        {
            return this.playerWon;
        }

        /// <summary>
        /// Return the name of the winning player.
        /// </summary>
        /// <returns>String name of the winning player.</returns>
        public string GetWinnerName()
        {
            return this.winner.GetName();
        }

        /// <summary>
        /// Pop the top card off of each players hand and deal it into the face up cards.
        /// </summary>
        public void DealHand()
        {
            // Switching to iterator so that it is easier to determine who won
            for (int i = 0; i < this.gamePlayers.Count; i++)
            {
                Player p = this.gamePlayers[i];
                try
                {
                    Card c = p.GetTopCard();
                    faceUpCards[p.GetName()].Add(c);
                    p.SetPicturePath(c.Img);
                }
                catch (PlayerOutOfCardsException)
                {
                    // If this exception is thrown in this function, the player loses
                    DeclareWinner(i);
                }
            }
        }

        /// <summary>
        /// A player has won the card game. Set the appropriate indicators
        /// </summary>
        /// <param name="loser">Integer index in the players list of the losing player</param>
        private void DeclareWinner(int loser)
        {
            // Only works for 2 player games, but this will pull the winning player.
            Player winner = this.gamePlayers[((loser + 1) % 2)];
            this.winner = winner;
            this.playerWon = true;
        }

        /// <summary>
        /// Check the top face-up card for each player. Determine who wins or declare a war!
        /// </summary>
        /// <returns>True if a war is determined</returns>
        public Boolean DetermineHandWinner()
        {
            Boolean isWar = false;
            // So, there are lots of function calls here. Keep an eye on the performance of these lines.
            Card PlayerACard = faceUpCards[gamePlayers[0].GetName()].ElementAt(faceUpCards[gamePlayers[0].GetName()].Count - 1);
            Card PlayerBCard = faceUpCards[gamePlayers[1].GetName()].ElementAt(faceUpCards[gamePlayers[1].GetName()].Count - 1);
            if (PlayerACard.Value > PlayerBCard.Value)
            {
                // Player A wins, give them all the cards
                GivePlayerAllCards(gamePlayers[0]);
            }
            else if (PlayerACard.Value == PlayerBCard.Value)
            {
                //this.HandleWar();
                isWar = true;
            }
            else
            {
                // Player B wins, give them all the cards
                GivePlayerAllCards(gamePlayers[1]);
            }

            foreach(Player p in gamePlayers)
            {
                p.UpdateCardCount();
            }

            return isWar;
        }

        /// <summary>
        /// In the case of a war, deal a face down card and another face up card.
        /// It is possible for a player to not have enough cards. In that case either
        /// their face down card becomes their face up card or the face up card does not change.
        /// </summary>
        public void DealWar()
        {
            foreach (Player p in gamePlayers)
            { 
                // TODO: Count the number of times this first error is thrown. If
                // it is equal to the number of game players, then nobody has any
                // additional cards and we've got a tie.
                try
                {
                    faceDownCards[p.GetName()].Add(p.GetTopCard());
                }
                catch (PlayerOutOfCardsException)
                {
                    // They don't have anymore cards, just move on
                    continue;
                }

                try
                {
                    Card c = p.GetTopCard();
                    faceUpCards[p.GetName()].Add(c);
                    p.SetPicturePath(c.Img);
                }
                catch (PlayerOutOfCardsException)
                {
                    // Take the top card out of the face down card pile for this player an flip it.
                    Card c = faceDownCards[p.GetName()].Last();
                    faceUpCards[p.GetName()].Add(c);
                    faceDownCards[p.GetName()].RemoveAt(faceDownCards[p.GetName()].Count - 1);
                    p.SetPicturePath(c.Img);
                }
            }
        }

        /// <summary>
        /// Once a winner is determined, give that player all of the cards on the board.
        /// </summary>
        /// <param name="winner">The winning player</param>
        private void GivePlayerAllCards(Player winner)
        {
            foreach (Player p in gamePlayers)
            {
                winner.AddMultipleCards(faceUpCards[p.GetName()]);
                faceUpCards[p.GetName()].Clear();
                winner.AddMultipleCards(faceDownCards[p.GetName()]);
                faceDownCards[p.GetName()].Clear();
            }
        }
    }
}