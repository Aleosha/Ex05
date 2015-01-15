using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ex2;

namespace Ex05
{
    public partial class GameSettingsForm : Form
    {       
        public GameSettingsForm()
        {
            InitializeComponent();
        }

        private void player2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox player2HumanCheckBox = (CheckBox)sender;

            if (player2HumanCheckBox.Checked) 
            {
                player2TextBox.Text = string.Empty;                
                player2TextBox.Enabled = true;
                player2TextBox.Focus();
            }
            else
            {
                player2TextBox.Text = "[Computer]";
                player2TextBox.Enabled = false;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (player1TextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Player 1 name must not be empty");
                player1TextBox.Focus();
            }
            else if (player2CheckBox.Checked && player2TextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Player 2 name must not be empty");
                player2TextBox.Focus();
            }
            else
            {
                int boardSize = (int)rowsNumericUpDownBox.Value;
                ePlayerType secondPlayerType = player2CheckBox.Checked ? ePlayerType.HUMAN : ePlayerType.COMPUTER;
                Form form = new GameForm(boardSize, secondPlayerType, player1TextBox.Text, player2TextBox.Text);
                form.Show();
                this.Hide();
                form.FormClosed += new FormClosedEventHandler(onGameFormClosed);
            }           
        }

        private void onGameFormClosed(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rowsNumericUpDownBox_ValueChanged(object sender, EventArgs e)
        {
            colsNumericUpDownBox.Value = ((NumericUpDown)sender).Value;
        }

        private void colsNumericUpDownBox_ValueChanged(object sender, EventArgs e)
        {
            rowsNumericUpDownBox.Value = ((NumericUpDown)sender).Value;
        }    
    }
}
