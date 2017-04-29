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
            }
        }
    }
}
