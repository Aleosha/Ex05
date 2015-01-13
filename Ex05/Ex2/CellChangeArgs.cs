using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class CellChangeArgs : EventArgs
    {
        private int m_Row;
        private int m_Cols;

        public CellChangeArgs(int i_Row, int i_Cols)
        {
            this.m_Row = i_Row;
            this.m_Cols = i_Cols;
        }
    }
}
