﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGameWar
{
    public partial class War : Form
    {
        private WarGameBoard gameBoard;

        public War()
        {
            InitializeComponent();
        }

        public void WarForm_OnMenuItemClick(object sender, EventArgs e)
        {
            if(sender == this.exitToolStripMenuItem)
            {
                // Exit the game
                this.Close();
            }
            else if (sender == this.startGameToolStripMenuItem)
            {
                // start game
                this.WarForm_ShowNameInput();
            }
        }

        public void WarForm_ShowNameInput()
        {
            this.Warform_ToggleNameInputs(true);
        }

        private void WarForm_HideNameInput()
        {
            this.Warform_ToggleNameInputs(false);
        }

        private void Warform_ToggleNameInputs(Boolean show)
        {
            this.userNameTextBox.Visible = show;
            this.userNameInputLabel.Visible = show;
            this.UserNameAcceptButton.Visible = show;
        }

        private List<Player> SetupPlayers()
        {
            Player user = new Player(this.userNameTextBox.Text, this.PlayerTopCard);
            Player comp = new Player("Computer", this.ComputerTopCard);
            List<Player> players = new List<Player>();
            players.Add(user);
            players.Add(comp);
            return players;
        }

        private void WarForm_UserNameAcceptButton_Click(object sender, EventArgs e)
        {
            this.WarForm_HideNameInput();

            gameBoard = new WarGameBoard(this.SetupPlayers());

            while (!gameBoard.HasWinner())
            {
                gameBoard.PlayNextHand();
            }
            this.winnerBanner.Text = gameBoard.GetWinnerName();
            this.winnerBanner.Visible = true;
        }

        private void WarForm_DealHand_Click(object sender, EventArgs e)
        {
            
        }
    }
}
