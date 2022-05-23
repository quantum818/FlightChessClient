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
        public String host = "";
        public Boolean inLast = false;
        public Boolean isOut = false;
        public Boolean isStart = false;
        public Boolean isChange = false;
        public ChessRowList startRow = null;
        public ChessRowList LastRow = null;
        public int nowLocal = 0;
        public ChessRowList nowRow = null;
        public Point ChessOrigin = new Point();
        public Point ChessStartArea = new Point();
        public List<Chess> otherChess = new List<Chess>();
        public GroupBox parentBox = null;
        public Image OrginImage = null;
        public Chess()
        {
            otherChess.Add(this);
            InitializeComponent();
        }
        public int localRow(ChessBoard ind)
        {
            if (nowRow == ind.ChessRow1) return 1;
            else if (nowRow == ind.ChessRow2) return 2;
            else if (nowRow == ind.ChessRow3) return 3;
            else if (nowRow == ind.ChessRow4) return 4;
            else if (nowRow == LastRow) return 5;
            else return -1;
        }
        public void getRow(int RowNum,ChessBoard ind)
        {
            switch (RowNum)
            {
                case 1:nowRow = ind.ChessRow1;break;
                case 2: nowRow = ind.ChessRow2; break;
                case 3: nowRow = ind.ChessRow3; break;
                case 4: nowRow = ind.ChessRow4; break;
                case 5: nowRow = LastRow;break;
                default:break;
            }
        }
        public Chess(IContainer container)
        {
            container.Add(this);
            otherChess.Add(this);
            InitializeComponent();
        }
    }
}
