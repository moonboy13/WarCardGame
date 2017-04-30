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
        private List<Player> gamePlayers;
        private List<Card> deck;
        private Dictionary<String, List<Card>> faceUpCards;
        private Dictionary<String, List<Card>> faceDownCards;
        private Boolean playerWon = false;
        private Player winner;

        public void AddPlayer(Player newPlayer)
        {
            this.gamePlayers.Add(newPlayer);
        }

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

        private void DealDeck()
        {
            int counter = 1;
            foreach(Card c in this.deck)
            {
                this.gamePlayers[counter % 2].AddCard(c);
                counter++;
            }
        }

        public Boolean HasWinner()
        {
            return this.playerWon;
        }

        public string GetWinnerName()
        {
            return this.winner.GetName();
        }

        /// <summary>
        /// Flip the next set of cards from each player and determine a winner for the hand.
        /// </summary>
        public void PlayNextHand()
        {
            // Switching to iterator so that it is easier to determine who won
            for (int i = 0; i < this.gamePlayers.Count; i++)
            {
                Player p = this.gamePlayers[i];
                try
                {
                    faceUpCards[p.GetName()].Add(p.GetTopCard());
                }
                catch (PlayerOutOfCardsException)
                {
                    // If this exception is thrown in this function, the player loses
                    this.DeclareWinner(i);
                }
            }

            if (!this.playerWon)
            {
                this.DetermineHandWinner();
            }
        }

        private void DeclareWinner(int loser)
        {
            // Only works for 2 player games, but this will pull the winning player.
            Player winner = this.gamePlayers[((loser + 1) % 2)];
            this.winner = winner;
            this.playerWon = true;
        }

        /// <summary>
        /// Check the top face-up card for each player. Determine who wins or declare a war!s
        /// </summary>
        private void DetermineHandWinner()
        {
            // So, there are lots of function calls here. Keep an eye on the performance of these lines.
            Card PlayerACard = faceUpCards[gamePlayers[0].GetName()].ElementAt(faceUpCards[gamePlayers[0].GetName()].Count - 1);
            Card PlayerBCard = faceUpCards[gamePlayers[1].GetName()].ElementAt(faceUpCards[gamePlayers[1].GetName()].Count - 1);
            if (PlayerACard.GetValue() > PlayerBCard.GetValue())
            {
                // Player A wins, give them all the cards
                this.GivePlayerAllCards(gamePlayers[0]);
            }
            else if (PlayerACard.GetValue() == PlayerBCard.GetValue())
            {
                this.HandleWar();
            }
            else
            {
                // Player B wins, give them all the cards
                this.GivePlayerAllCards(gamePlayers[1]);
            }
        }

        /// <summary>
        /// Deal out the cards for war and then move onto checking for a winner.
        /// </summary>
        private void HandleWar()
        {
            foreach (Player p in gamePlayers)
            {
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
                    faceUpCards[p.GetName()].Add(p.GetTopCard());
                }
                catch (PlayerOutOfCardsException)
                {
                    // Take the top card out of the face down card pile for this player an flip it.
                    faceUpCards[p.GetName()].Add(faceDownCards[p.GetName()].Last());
                    faceDownCards[p.GetName()].RemoveAt(faceDownCards[p.GetName()].Count - 1);
                }
            }

            this.DetermineHandWinner();
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