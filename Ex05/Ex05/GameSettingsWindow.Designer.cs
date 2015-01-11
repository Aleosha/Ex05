﻿namespace Ex05
{
    partial class GameSettingsWindow
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
            this.button1 = new System.Windows.Forms.Button();
            this.playersLabel = new System.Windows.Forms.Label();
            this.player1Label = new System.Windows.Forms.Label();
            this.player1TextBox = new System.Windows.Forms.TextBox();
            this.player2CheckBox = new System.Windows.Forms.CheckBox();
            this.player2TextBox = new System.Windows.Forms.TextBox();
            this.boardSizeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start!";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // playersLabel
            // 
            this.playersLabel.AutoSize = true;
            this.playersLabel.Location = new System.Drawing.Point(25, 22);
            this.playersLabel.Name = "playersLabel";
            this.playersLabel.Size = new System.Drawing.Size(44, 13);
            this.playersLabel.TabIndex = 1;
            this.playersLabel.Text = "Players:";
            this.playersLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Location = new System.Drawing.Point(25, 55);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(48, 13);
            this.player1Label.TabIndex = 2;
            this.player1Label.Text = "Player 1:";
            // 
            // player1TextBox
            // 
            this.player1TextBox.Location = new System.Drawing.Point(117, 55);
            this.player1TextBox.Name = "player1TextBox";
            this.player1TextBox.Size = new System.Drawing.Size(100, 20);
            this.player1TextBox.TabIndex = 3;
            // 
            // player2CheckBox
            // 
            this.player2CheckBox.AutoSize = true;
            this.player2CheckBox.Location = new System.Drawing.Point(28, 88);
            this.player2CheckBox.Name = "player2CheckBox";
            this.player2CheckBox.Size = new System.Drawing.Size(67, 17);
            this.player2CheckBox.TabIndex = 4;
            this.player2CheckBox.Text = "Player 2:";
            this.player2CheckBox.UseVisualStyleBackColor = true;
            this.player2CheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // player2TextBox
            // 
            this.player2TextBox.Enabled = false;
            this.player2TextBox.Location = new System.Drawing.Point(117, 88);
            this.player2TextBox.Name = "player2TextBox";
            this.player2TextBox.Size = new System.Drawing.Size(100, 20);
            this.player2TextBox.TabIndex = 5;
            this.player2TextBox.Text = "Computer";
            // 
            // boardSizeLabel
            // 
            this.boardSizeLabel.AutoSize = true;
            this.boardSizeLabel.Location = new System.Drawing.Point(28, 152);
            this.boardSizeLabel.Name = "boardSizeLabel";
            this.boardSizeLabel.Size = new System.Drawing.Size(59, 13);
            this.boardSizeLabel.TabIndex = 6;
            this.boardSizeLabel.Text = "Board size:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rows:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(29, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cols:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(188, 172);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(29, 20);
            this.textBox2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 261);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boardSizeLabel);
            this.Controls.Add(this.player2TextBox);
            this.Controls.Add(this.player2CheckBox);
            this.Controls.Add(this.player1TextBox);
            this.Controls.Add(this.player1Label);
            this.Controls.Add(this.playersLabel);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Game Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label playersLabel;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.TextBox player1TextBox;
        private System.Windows.Forms.CheckBox player2CheckBox;
        private System.Windows.Forms.TextBox player2TextBox;
        private System.Windows.Forms.Label boardSizeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}

