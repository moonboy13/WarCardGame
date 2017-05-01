namespace CardGameWar
{
    partial class War
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userNameInputLabel = new System.Windows.Forms.Label();
            this.UserNameAcceptButton = new System.Windows.Forms.Button();
            this.winnerBanner = new System.Windows.Forms.Label();
            this.PlayerTopCard = new System.Windows.Forms.PictureBox();
            this.ComputerTopCard = new System.Windows.Forms.PictureBox();
            this.UserName = new System.Windows.Forms.Label();
            this.ComputerName = new System.Windows.Forms.Label();
            this.DealHand = new System.Windows.Forms.Button();
            this.playerCardCount = new System.Windows.Forms.Label();
            this.computerCardCount = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerTopCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerTopCard)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startGameToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1276, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startGameToolStripMenuItem
            // 
            this.startGameToolStripMenuItem.Name = "startGameToolStripMenuItem";
            this.startGameToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.startGameToolStripMenuItem.Text = "Start Game";
            this.startGameToolStripMenuItem.Click += new System.EventHandler(this.WarForm_OnMenuItemClick);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(51, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.WarForm_OnMenuItemClick);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(34, 29);
            this.toolStripMenuItem1.Text = "  ";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(559, 268);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(162, 26);
            this.userNameTextBox.TabIndex = 1;
            this.userNameTextBox.Visible = false;
            // 
            // userNameInputLabel
            // 
            this.userNameInputLabel.AutoSize = true;
            this.userNameInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameInputLabel.Location = new System.Drawing.Point(554, 239);
            this.userNameInputLabel.Name = "userNameInputLabel";
            this.userNameInputLabel.Size = new System.Drawing.Size(176, 25);
            this.userNameInputLabel.TabIndex = 2;
            this.userNameInputLabel.Text = "Enter Your Name";
            this.userNameInputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userNameInputLabel.Visible = false;
            // 
            // UserNameAcceptButton
            // 
            this.UserNameAcceptButton.Location = new System.Drawing.Point(559, 300);
            this.UserNameAcceptButton.Name = "UserNameAcceptButton";
            this.UserNameAcceptButton.Padding = new System.Windows.Forms.Padding(3);
            this.UserNameAcceptButton.Size = new System.Drawing.Size(80, 35);
            this.UserNameAcceptButton.TabIndex = 3;
            this.UserNameAcceptButton.Text = "Accept";
            this.UserNameAcceptButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.UserNameAcceptButton.UseVisualStyleBackColor = true;
            this.UserNameAcceptButton.Visible = false;
            this.UserNameAcceptButton.Click += new System.EventHandler(this.WarForm_UserNameAcceptButton_Click);
            // 
            // winnerBanner
            // 
            this.winnerBanner.AutoSize = true;
            this.winnerBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerBanner.Location = new System.Drawing.Point(497, 79);
            this.winnerBanner.Name = "winnerBanner";
            this.winnerBanner.Size = new System.Drawing.Size(0, 37);
            this.winnerBanner.TabIndex = 4;
            this.winnerBanner.Visible = false;
            // 
            // PlayerTopCard
            // 
            this.PlayerTopCard.BackColor = System.Drawing.Color.Ivory;
            this.PlayerTopCard.Location = new System.Drawing.Point(129, 191);
            this.PlayerTopCard.Name = "PlayerTopCard";
            this.PlayerTopCard.Size = new System.Drawing.Size(194, 297);
            this.PlayerTopCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PlayerTopCard.TabIndex = 5;
            this.PlayerTopCard.TabStop = false;
            this.PlayerTopCard.Visible = false;
            // 
            // ComputerTopCard
            // 
            this.ComputerTopCard.BackColor = System.Drawing.Color.Ivory;
            this.ComputerTopCard.Location = new System.Drawing.Point(920, 191);
            this.ComputerTopCard.Name = "ComputerTopCard";
            this.ComputerTopCard.Size = new System.Drawing.Size(194, 297);
            this.ComputerTopCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ComputerTopCard.TabIndex = 6;
            this.ComputerTopCard.TabStop = false;
            this.ComputerTopCard.Visible = false;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(195, 140);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(0, 20);
            this.UserName.TabIndex = 7;
            this.UserName.Visible = false;
            // 
            // ComputerName
            // 
            this.ComputerName.AutoSize = true;
            this.ComputerName.Location = new System.Drawing.Point(916, 140);
            this.ComputerName.Name = "ComputerName";
            this.ComputerName.Size = new System.Drawing.Size(0, 20);
            this.ComputerName.TabIndex = 9;
            this.ComputerName.Visible = false;
            // 
            // DealHand
            // 
            this.DealHand.Location = new System.Drawing.Point(559, 493);
            this.DealHand.Name = "DealHand";
            this.DealHand.Size = new System.Drawing.Size(171, 54);
            this.DealHand.TabIndex = 10;
            this.DealHand.Text = "Deal";
            this.DealHand.UseVisualStyleBackColor = true;
            this.DealHand.Visible = false;
            this.DealHand.Click += new System.EventHandler(this.WarForm_DealHand_Click);
            // 
            // playerCardCount
            // 
            this.playerCardCount.AutoSize = true;
            this.playerCardCount.Location = new System.Drawing.Point(199, 507);
            this.playerCardCount.Name = "playerCardCount";
            this.playerCardCount.Size = new System.Drawing.Size(0, 20);
            this.playerCardCount.TabIndex = 11;
            // 
            // computerCardCount
            // 
            this.computerCardCount.AutoSize = true;
            this.computerCardCount.Location = new System.Drawing.Point(1011, 507);
            this.computerCardCount.Name = "computerCardCount";
            this.computerCardCount.Size = new System.Drawing.Size(0, 20);
            this.computerCardCount.TabIndex = 12;
            this.computerCardCount.Visible = false;
            // 
            // War
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1276, 701);
            this.Controls.Add(this.computerCardCount);
            this.Controls.Add(this.playerCardCount);
            this.Controls.Add(this.DealHand);
            this.Controls.Add(this.ComputerName);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.ComputerTopCard);
            this.Controls.Add(this.PlayerTopCard);
            this.Controls.Add(this.winnerBanner);
            this.Controls.Add(this.UserNameAcceptButton);
            this.Controls.Add(this.userNameInputLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "War";
            this.Text = "War";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerTopCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerTopCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label userNameInputLabel;
        private System.Windows.Forms.Button UserNameAcceptButton;
        private System.Windows.Forms.Label winnerBanner;
        private System.Windows.Forms.PictureBox PlayerTopCard;
        private System.Windows.Forms.PictureBox ComputerTopCard;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label ComputerName;
        private System.Windows.Forms.Button DealHand;
        private System.Windows.Forms.Label playerCardCount;
        private System.Windows.Forms.Label computerCardCount;
    }
}

