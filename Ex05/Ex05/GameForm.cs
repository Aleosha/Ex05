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
    public partial class GameForm : Form
    {
        private int m_BoardSize;
        private FlowLayoutPanel m_GamePanel = new FlowLayoutPanel();

        private Ex2.GameLogic m_GameLogic;
        const int k_CellSize = 50;
        List<Button> cells = new List<Button>();

        public GameForm()
        {
            InitializeComponent();
        }

        public GameForm(int i_BoardSize, ePlayerType i_SecondPlayerType)
        {
            this.m_BoardSize = i_BoardSize;
            initWindow();
            this.m_GamePanel.Size = new Size(k_CellSize * i_BoardSize + k_CellSize, k_CellSize * i_BoardSize + k_CellSize);
            
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
            Button clickedButton = cells[index];
            clickedButton.Enabled = false;
            clickedButton.Text = m_GameLogic.CurrPlayer.ToString();
        }

        private void initWindow()
        {
            int windowWidth = (int)(k_CellSize * m_BoardSize + k_CellSize * 1.5);
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

                    cells.Add(btn);
                    btn.Tag = count++;
                }
            }
            this.Controls.Add(m_GamePanel);            
        }

        private void cellClickEventHandler(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            setCell((int)clickedButton.Tag);

            if (!m_GameLogic.IsGameOver())
            {
                m_GameLogic.AlternatePlayers();
            }
            else
            {
                handleGameOver();
            }
        }

        private void handleGameOver()
        {
            string gameOverMessage = m_GameLogic.GameTerminationStatus.ToString();

            if (eGameTerminationStatus.WON.Equals(m_GameLogic.GameTerminationStatus))
            {
                gameOverMessage = m_GameLogic.CurrPlayer.ToString() + " won!";
            }
            else if (eGameTerminationStatus.TIE.Equals(m_GameLogic.GameTerminationStatus))
            {
                gameOverMessage = "It's a tie";
            }
            DialogResult result = MessageBox.Show(gameOverMessage, "Game over", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                this.Close();
            }
            // Start again
            else 
            {
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
