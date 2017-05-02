using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CardGameWar
{
    public partial class War : Form
    {
        /// <summary>
        /// Reference to the game board for the form. The board handles the game logic.
        /// </summary>
        private WarGameBoard gameBoard;

        public War()
        {
            InitializeComponent();
            gameBoard = new WarGameBoard();
        }

        /// <summary>
        /// Handle the click event for various menu items along the top of the form.
        /// </summary>
        /// <param name="sender">The object emitting the event.</param>
        /// <param name="e"></param>
        public void WarForm_OnMenuItemClick(object sender, EventArgs e)
        {
            if(sender == this.exitToolStripMenuItem)
            {
                // Exit the game
                Close();
            }
            else if (sender == this.startGameToolStripMenuItem)
            {
                gameBoard.Reset();
                // start game
                WarForm_HideGameInputs();
                WarForm_ShowNameInput();
            }
        }

        /// <summary>
        /// Show all of the inputs for entering a user name.
        /// </summary>
        public void WarForm_ShowNameInput()
        {
            Warform_ToggleNameInputs(true);
        }

        /// <summary>
        /// Hide all of the inputs for entering a user name.
        /// </summary>
        private void WarForm_HideNameInput()
        {
            Warform_ToggleNameInputs(false);
        }

        /// <summary>
        /// Handle showing or hiding user name inputs.
        /// </summary>
        /// <param name="show"></param>
        private void Warform_ToggleNameInputs(Boolean show)
        {
            userNameTextBox.Visible = show;
            userNameInputLabel.Visible = show;
            UserNameAcceptButton.Visible = show;
            if (show)
            {
                userNameTextBox.Focus();
            }
        }

        /// <summary>
        /// Initialize the game player objects.
        /// </summary>
        /// <returns>List of players, computer or otherwise, competing in the game.</returns>
        private List<Player> SetupPlayers()
        {
            // TODO: Perform validation on userNameTextBox.Text to make sure its not anything malicious.
            Player user = new Player(userNameTextBox.Text, PlayerTopCard, playerCardCount);
            UserName.Text = userNameTextBox.Text;
            Player comp = new Player("Computer", ComputerTopCard, computerCardCount);
            ComputerName.Text = "Computer";
            List<Player> players = new List<Player>
            {
                user,
                comp
            };
            return players;
        }

        /// <summary>
        /// Once a user has chosen their name, proceed with starting the game up and showing the
        /// appropriate inputs to play the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WarForm_UserNameAcceptButton_Click(object sender, EventArgs e)
        {
            WarForm_HideNameInput();

            gameBoard.InitGame(SetupPlayers());

            // Reset to a default value.
            cardsInPlayLabel.Text = "Cards in Play:";

            WarForm_ShowGameInputs();
        }

        /// <summary>
        /// Show the game inputs through the toggle functin.
        /// </summary>
        private void WarForm_ShowGameInputs()
        {
            WarForm_ToggleGameInputs(true);
        }

        /// <summary>
        /// Hide the game inputs through the toggle function.
        /// </summary>
        private void WarForm_HideGameInputs()
        {
            WarForm_ToggleGameInputs(false);
        }

        /// <summary>
        /// Handle either hiding or showing the inputs for the game. Useful when the player wants
        /// to reset and play a new game.
        /// </summary>
        /// <param name="show">Boolean toggle to hide or show</param>
        private void WarForm_ToggleGameInputs(Boolean show)
        {
            PlayerTopCard.Visible = show;
            ComputerTopCard.Visible = show;
            UserName.Visible = show;
            ComputerName.Visible = show;
            DealHand.Visible = show;
            playerCardCount.Visible = show;
            computerCardCount.Visible = show;
            cardsInPlayLabel.Visible = show;
        }

        /// <summary>
        /// When the player clicks the button to deal a hand, handle dealing out the
        /// new cards, determining the winner of the hand, figuring out if a war needs
        /// to be fought, and finally declare a winner once appropriate.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WarForm_DealHand_Click(object sender, EventArgs e)
        {
            gameBoard.UpdateCardCount();
            gameBoard.DealHand();
            cardsInPlayLabel.Text = "Cards in Play: " + gameBoard.GetCardsInPlayCount().ToString();

            if (!gameBoard.HasWinner())
            {
                // Returns true if a war is determined
                while (gameBoard.DetermineHandWinner())
                {
                    gameBoard.DealWar();
                    cardsInPlayLabel.Text = "Cards in Play: " + gameBoard.GetCardsInPlayCount().ToString();
                }
            }
            else
            {
                winnerBanner.Text = gameBoard.GetWinnerName() + " is the winner!";
                winnerBanner.Visible = true;
                DealHand.Visible = false;
            }

            // This is a hack to get the UI to update correctly, to avoid a mis-match
            // between what the card count is and what the user sees. Ideally, the UI
            // rendering would occur on a separate thread from the game logic.
            Application.DoEvents();
        }
    }
}
