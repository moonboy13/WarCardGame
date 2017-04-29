using System;
using System.Collections.Generic;
using System.Linq;
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
        private List<Player> GamePlayers;
        private List<Card> Deck;
        private Dictionary<String, List<Card>> FaceUpCards;
        private Dictionary<String, List<Card>> FaceDownCards;

        public void AddPlayer(Player newPlayer)
        {
            GamePlayers.Add(newPlayer);
        }

        public WarGameBoard(Player user)
        {
            this.AddPlayer(user);
            Player comp = new Player();
            comp.SetName("Computer");
            this.AddPlayer(comp);
            this.InitDeck();
        }

        private void InitDeck()
        {

        }

        public Boolean HasWinner()
        {
            return false;
        }

        /// <summary>
        /// Flip the next set of cards from each player and determine a winner for the hand.
        /// </summary>
        public void PlayNextHand()
        {
            foreach (Player p in GamePlayers)
            {
                FaceUpCards[p.GetName()].Add(p.GetTopCard());
            }

            this.DetermineHandWinner();
        }

        /// <summary>
        /// Check the top face-up card for each player. Determine who wins or declare a war!s
        /// </summary>
        private void DetermineHandWinner()
        {
            // So, there are lots of function calls here. Keep an eye on the performance of these lines.
            Card PlayerACard = FaceUpCards[GamePlayers[0].GetName()].ElementAt(FaceUpCards[GamePlayers[0].GetName()].Count - 1);
            Card PlayerBCard = FaceUpCards[GamePlayers[1].GetName()].ElementAt(FaceUpCards[GamePlayers[1].GetName()].Count - 1);
            if (PlayerACard.GetValue() > PlayerBCard.GetValue())
            {
                // Player A wins, give them all the cards
                this.GivePlayerAllCards(GamePlayers[0]);
            }
            else if (PlayerACard.GetValue() == PlayerBCard.GetValue())
            {
                this.HandleWar();
            }
            else
            {
                // Player B wins, give them all the cards
                this.GivePlayerAllCards(GamePlayers[1]);
            }
        }

        /// <summary>
        /// Deal out the cards for war and then move onto checking for a winner.
        /// </summary>
        private void HandleWar()
        {
            foreach (Player p in GamePlayers)
            {
                FaceDownCards[p.GetName()].Add(p.GetTopCard());
                FaceUpCards[p.GetName()].Add(p.GetTopCard());
            }

            this.DetermineHandWinner();
        }

        /// <summary>
        /// Once a winner is determined, give that player all of the cards on the board.
        /// </summary>
        /// <param name="winner">The winning player</param>
        private void GivePlayerAllCards(Player winner)
        {
            foreach (Player p in GamePlayers)
            {
                winner.AddMultipleCards(FaceUpCards[p.GetName()]);
                winner.AddMultipleCards(FaceDownCards[p.GetName()]);
            }
        }
    }
}