using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ex05
{
    public partial class GameSettingsForm : Form
    {       
        public GameSettingsForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void player2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox player2HumanCheckBox = (CheckBox)sender;

            if (player2HumanCheckBox.Enabled) 
            {
                player2TextBox.Text = "";
                player2TextBox.Focus();
                player2TextBox.Enabled = true;
            }
            else
            {
                player2TextBox.Text = "Computer";
                player2TextBox.Enabled = false;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Form form = new GameForm((int) rowsNumericUpDownBox.Value);
            form.Show();
            this.Hide();
            form.FormClosed += new FormClosedEventHandler(onGameFormClosed);
        }

        private void onGameFormClosed(object sender, EventArgs e)
        {
            //this.Show();
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
