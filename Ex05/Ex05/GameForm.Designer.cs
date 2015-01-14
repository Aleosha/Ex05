namespace Ex05
{
    partial class GameForm
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
            this.player1ScoreLabel = new System.Windows.Forms.Label();
            this.player2ScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // player1ScoreLabel
            // 
            this.player1ScoreLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.player1ScoreLabel.AutoSize = true;
            this.player1ScoreLabel.Location = new System.Drawing.Point(82, 266);
            this.player1ScoreLabel.Name = "player1ScoreLabel";
            this.player1ScoreLabel.Size = new System.Drawing.Size(57, 13);
            this.player1ScoreLabel.TabIndex = 0;
            this.player1ScoreLabel.Text = "Player 1: 0";
            // 
            // player2ScoreLabel
            // 
            this.player2ScoreLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.player2ScoreLabel.AutoSize = true;
            this.player2ScoreLabel.Location = new System.Drawing.Point(145, 266);
            this.player2ScoreLabel.Name = "player2ScoreLabel";
            this.player2ScoreLabel.Size = new System.Drawing.Size(57, 13);
            this.player2ScoreLabel.TabIndex = 1;
            this.player2ScoreLabel.Text = "Player 2: 0";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 288);
            this.Controls.Add(this.player2ScoreLabel);
            this.Controls.Add(this.player1ScoreLabel);
            this.Name = "GameForm";
            this.Text = "TicTacToeMisere";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label player1ScoreLabel;
        private System.Windows.Forms.Label player2ScoreLabel;

    }
}