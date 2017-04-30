﻿namespace CardGameWar
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
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1194, 33);
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
            this.userNameTextBox.Location = new System.Drawing.Point(480, 267);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(162, 26);
            this.userNameTextBox.TabIndex = 1;
            this.userNameTextBox.Visible = false;
            // 
            // userNameInputLabel
            // 
            this.userNameInputLabel.AutoSize = true;
            this.userNameInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameInputLabel.Location = new System.Drawing.Point(476, 244);
            this.userNameInputLabel.Name = "userNameInputLabel";
            this.userNameInputLabel.Size = new System.Drawing.Size(176, 25);
            this.userNameInputLabel.TabIndex = 2;
            this.userNameInputLabel.Text = "Enter Your Name";
            this.userNameInputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userNameInputLabel.Visible = false;
            // 
            // UserNameAcceptButton
            // 
            this.UserNameAcceptButton.Location = new System.Drawing.Point(480, 300);
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
            // War
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1194, 474);
            this.Controls.Add(this.UserNameAcceptButton);
            this.Controls.Add(this.userNameInputLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "War";
            this.Text = "War";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}
