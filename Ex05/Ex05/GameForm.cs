using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex05
{
    public partial class GameForm : Form
    {
        private int m_BoardSize;
        private FlowLayoutPanel m_GamePanel = new FlowLayoutPanel();

        const int k_CellSize = 50;

        public GameForm()
        {
            InitializeComponent();
        }

        public GameForm(int i_BoardSize)
        {
            this.m_BoardSize = i_BoardSize;
            this.Size = new Size(k_CellSize * i_BoardSize + 50, k_CellSize * i_BoardSize + 75);
            this.m_GamePanel.Size = new Size(k_CellSize * i_BoardSize + 50, k_CellSize * i_BoardSize + 50);

            for (int i = 0; i < m_BoardSize; i++)
            {
                for (int j = 0; j < m_BoardSize; j++)
                {
                    Button btn = new Button();
                    {
                        btn.Size = new Size(k_CellSize, k_CellSize);
                    }
                    m_GamePanel.Controls.Add(btn);
                    //btn.Click += Buttons_Click;   
                }                                            
            }
            this.Controls.Add(m_GamePanel);            
        }
    }
}
