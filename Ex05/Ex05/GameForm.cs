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

        public GameForm()
        {
            InitializeComponent();
        }

        public GameForm(int i_BoardSize, ePlayerType i_SecondPlayerType)
        {
            this.m_BoardSize = i_BoardSize;
            this.Size = new Size(k_CellSize * i_BoardSize + 50, k_CellSize * i_BoardSize + 75);
            this.m_GamePanel.Size = new Size(k_CellSize * i_BoardSize + 50, k_CellSize * i_BoardSize + 50);

            m_GameLogic = new GameLogic(i_BoardSize, i_SecondPlayerType);
            addCells();
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

                    btn.Tag = count++;
                }
            }
            this.Controls.Add(m_GamePanel);            
        }

        private void cellClickEventHandler(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Console.WriteLine(String.Format("Button {0} was clicked", clickedButton.Tag));
            clickedButton.Text = "X";
            clickedButton.Enabled = false;
        }       
    }
}
