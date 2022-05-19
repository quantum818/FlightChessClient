using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightChessClient
{
    public partial class Chess : PictureBox
    {
        public int ChessColor = 0;
        public int ChessCounts = 0;
        public int ChessNumber = 0;
        public Boolean inLast = false;
        public Boolean isOut = false;
        public ChessRowList startRow = null;
        public Point ChessOrigin = new Point();
        public Chess()
        {
            InitializeComponent();
        }

        public Chess(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
