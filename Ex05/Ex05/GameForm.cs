﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ex2;

namespace Ex05
{
    public partial class GameForm : Form
    {
        private int m_BoardSize;
        private FlowLayoutPanel m_GamePanel = new FlowLayoutPanel();

        private Ex2.GameLogic m_GameLogic;
        const int k_CellSize = 50;
        List<Button> m_Cells = new List<Button>();
        private string m_Player1Name;
        private string m_Player2Name;

        public GameForm()
        {
            InitializeComponent();
        }

        public GameForm(int i_BoardSize, ePlayerType i_SecondPlayerType, string i_Player1Name, string i_Player2Name)
        {
            InitializeComponent();
            this.m_BoardSize = i_BoardSize;
            m_Player1Name = i_Player1Name;
            m_Player2Name = i_Player2Name;
            initWindow();
            this.m_GamePanel.Size = new Size(k_CellSize * i_BoardSize, k_CellSize * i_BoardSize);
            
            addCells();

            m_GameLogic = new GameLogic(i_BoardSize, i_SecondPlayerType);

            m_GameLogic.ComputerPlayerTurn += onComputerPlayerTurn;
            m_GameLogic.CellChange += onCellChange;
        }

        private void onComputerPlayerTurn(object sender, EventArgs e)
        {
            MoveOption bestOption = ComputerPlayerLogic.GetBestOption(m_GameLogic);

            bool wasCellEmpty = m_GameLogic.SetCell(bestOption.Row, bestOption.Column, m_GameLogic.CurrPlayer.CellValue);
            m_GameLogic.AlternatePlayers();
        }

        private void onCellChange(object sender, Ex2.CellChangeArgs args)
        {
            int index = args.Row*m_BoardSize+args.Cols;
            Button clickedButton = m_Cells[index];
            clickedButton.Enabled = false;           
            clickedButton.Text = m_GameLogic.CurrPlayer.ToString();
        }

        private void initWindow()
        {
            int windowWidth = k_CellSize * m_BoardSize + k_CellSize;
            int windowHeight = k_CellSize * m_BoardSize + k_CellSize;
            this.Size = new Size(windowHeight, windowWidth);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void addCells()
        {
            int count = 0;
            for (int i = 0; i < m_BoardSize; i++)
            {
                for (int j = 0; j < m_BoardSize; j++)
                {
                    Button btn = new Button();
                    {
                        btn.Size = new Size(k_CellSize, k_CellSize);
                    }
                    m_GamePanel.Controls.Add(btn);
                    btn.Click += new EventHandler(cellClickEventHandler);
                    btn.Margin = new Padding(0);

                    m_Cells.Add(btn);
                    btn.Tag = count++;
                }
            }
            this.Controls.Add(m_GamePanel);            
        }

        private void cellClickEventHandler(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            setCell((int)clickedButton.Tag);

            m_GameLogic.AlternatePlayers();

            if(m_GameLogic.IsGameOver())
            {
                handleGameOver();
            }
        }

        private void handleGameOver()
        {
            string gameOverMessage = string.Empty;
            string messageBoxTitle = string.Empty;

            if (eGameTerminationStatus.WON.Equals(m_GameLogic.GameTerminationStatus))
            {
                messageBoxTitle = "A Win!";
                gameOverMessage = string.Format(
@"The winner is {0}!.
Would you like to play another round?", m_GameLogic.CurrPlayer.ToString() == "X" ? m_Player1Name : m_Player2Name);

            }
            else if (eGameTerminationStatus.TIE.Equals(m_GameLogic.GameTerminationStatus))
            {
                messageBoxTitle = "A Tie!";
                gameOverMessage = string.Format(
@"Tie!
Would you like to play another round?");
            }
            DialogResult result = MessageBox.Show(gameOverMessage, messageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.None);

            if (result == DialogResult.No)
            {
                this.Close();
            }
            // Start again
            else 
            {
                foreach(Button btn in m_Cells)
                {
                    btn.Enabled = true;
                    btn.Text = string.Empty;
                }
                m_GameLogic.MakeNewRound();
            }
        }

        private void setCell(int index)
        {
            int col = index % m_BoardSize;
            int row = index / m_BoardSize;

            m_GameLogic.SetCell(row + 1, col + 1, m_GameLogic.CurrPlayer.CellValue);
        }       
    }
}
