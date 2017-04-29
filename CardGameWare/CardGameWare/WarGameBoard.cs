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


        public void PlayNextHand()
        {
            foreach (Player p in GamePlayers)
            {
                FaceUpCards[p.GetName()].Add(p.GetTopCard());
            }

            this.DetermineHandWinner();
        }

        private void DetermineHandWinner()
        {

        }

        private void HandleWar()
        {
            foreach (Player p in GamePlayers)
            {
                FaceDownCards[p.GetName()].Add(p.GetTopCard());
                FaceUpCards[p.GetName()].Add(p.GetTopCard());
            }

            this.DetermineHandWinner();
        }
    }
}