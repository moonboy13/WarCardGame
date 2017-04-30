using System;
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
            this.userNameTextBox.Visible = true;
            this.userNameInputLabel.Visible = true;
            this.UserNameAcceptButton.Visible = true;
        }

        private void WarForm_UserNameAcceptButton_Click(object sender, EventArgs e)
        {
            Player user = new Player();
            user.SetName(this.userNameTextBox.Text);
            WarGameBoard gameBoard = new WarGameBoard(user);
            while (!gameBoard.HasWinner())
            {
                gameBoard.PlayNextHand();
            }
            this.winnerBanner.Text = gameBoard.GetWinnerName();
            this.winnerBanner.Visible = true;
        }
    }
}
