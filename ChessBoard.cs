using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightChessClient
{
    public class ChessBoard
    {
        private ChessRowList chessRow1 = new ChessRowList();
        private ChessRowList chessRow2 = new ChessRowList();
        private ChessRowList chessRow3 = new ChessRowList();
        private ChessRowList chessRow4 = new ChessRowList();
        private ChessRowList lastRowR = new ChessRowList();
        private ChessRowList lastRowB = new ChessRowList();
        private ChessRowList lastRowY = new ChessRowList();
        private ChessRowList lastRowG = new ChessRowList();
        private ChessRowList startRow = new ChessRowList();
        public ChessBoard()
        {
            chessRow1.Add(new ChessBock(504, 42, 0));
            chessRow1.Add(new ChessBock(519, 76, 1));
            chessRow1.Add(new ChessBock(518, 105, 2));
            chessRow1.Add(new ChessBock(506, 137, 3));
            chessRow1.Add(new ChessBock(531, 165, 0));
            chessRow1.Add(new ChessBock(562, 150, 1));
            chessRow1.Add(new ChessBock(591, 151, 2));
            chessRow1.Add(new ChessBock(628, 163, 3));
            chessRow1.Add(new ChessBock(635, 195, 0));
            chessRow1.Add(new ChessBock(635, 226, 1));
            chessRow1.Add(new ChessBock(637, 254, 2));
            chessRow1.Add(new ChessBock(638, 288, 3));
            chessRow1.Add(new ChessBock(637, 317, 0));

            chessRow2.Add(new ChessBock(628, 350, 1));
            chessRow2.Add(new ChessBock(594, 362, 2));
            chessRow2.Add(new ChessBock(566, 362, 3));
            chessRow2.Add(new ChessBock(532, 350, 0));
            chessRow2.Add(new ChessBock(507, 373, 1));
            chessRow2.Add(new ChessBock(515, 408, 2));
            chessRow2.Add(new ChessBock(517, 437, 3));
            chessRow2.Add(new ChessBock(507, 472, 0));
            chessRow2.Add(new ChessBock(470, 480, 1));
            chessRow2.Add(new ChessBock(441, 483, 2));
            chessRow2.Add(new ChessBock(413, 483, 3));
            chessRow2.Add(new ChessBock(379, 481, 0));
            chessRow2.Add(new ChessBock(351, 483, 1));

            chessRow3.Add(new ChessBock(317, 472, 2));
            chessRow3.Add(new ChessBock(306, 437, 3));
            chessRow3.Add(new ChessBock(306, 406, 0));
            chessRow3.Add(new ChessBock(318, 375, 1));
            chessRow3.Add(new ChessBock(295, 350, 2));
            chessRow3.Add(new ChessBock(263, 362, 3));
            chessRow3.Add(new ChessBock(233, 361, 0));
            chessRow3.Add(new ChessBock(198, 349, 1));
            chessRow3.Add(new ChessBock(187, 317, 2));
            chessRow3.Add(new ChessBock(183, 286, 3));
            chessRow3.Add(new ChessBock(187, 255, 0));
            chessRow3.Add(new ChessBock(184, 226, 1));
            chessRow3.Add(new ChessBock(186, 195, 2));

            chessRow4.Add(new ChessBock(195, 161, 3));
            chessRow4.Add(new ChessBock(230, 150, 0));
            chessRow4.Add(new ChessBock(260, 151, 1));
            chessRow4.Add(new ChessBock(292, 163, 2));
            chessRow4.Add(new ChessBock(318, 139, 3));
            chessRow4.Add(new ChessBock(307, 105, 0));
            chessRow4.Add(new ChessBock(305, 75, 1));
            chessRow4.Add(new ChessBock(317, 43, 2));
            chessRow4.Add(new ChessBock(356, 28, 3));
            chessRow4.Add(new ChessBock(382, 31, 0));
            chessRow4.Add(new ChessBock(411, 31, 1));
            chessRow4.Add(new ChessBock(443, 30, 2));
            chessRow4.Add(new ChessBock(472, 30, 3));

            lastRowR.Add(new ChessBock(412, 76, 1));
            lastRowR.Add(new ChessBock(412, 107, 1));
            lastRowR.Add(new ChessBock(412, 138, 1));
            lastRowR.Add(new ChessBock(414, 166, 1));
            lastRowR.Add(new ChessBock(412, 194, 1));
            lastRowR.Add(new ChessBock(413, 224, 1));

            lastRowB.Add(new ChessBock(592, 255, 2));
            lastRowB.Add(new ChessBock(559, 254, 2));
            lastRowB.Add(new ChessBock(531, 253, 2));
            lastRowB.Add(new ChessBock(502, 255, 2));
            lastRowB.Add(new ChessBock(475, 255, 2));
            lastRowB.Add(new ChessBock(445, 255, 2));

            lastRowY.Add(new ChessBock(413, 435, 3));
            lastRowY.Add(new ChessBock(413, 407, 3));
            lastRowY.Add(new ChessBock(411, 377, 3));
            lastRowY.Add(new ChessBock(413, 348, 3));
            lastRowY.Add(new ChessBock(410, 317, 3));
            lastRowY.Add(new ChessBock(411, 286, 3));

            lastRowG.Add(new ChessBock(233, 258, 0));
            lastRowG.Add(new ChessBock(263, 256, 0));
            lastRowG.Add(new ChessBock(293, 257, 0));
            lastRowG.Add(new ChessBock(323, 256, 0));
            lastRowG.Add(new ChessBock(351, 254, 0));
            lastRowG.Add(new ChessBock(380, 257, 0));

            chessRow1[12].nextRow = chessRow2;
            chessRow1[0].beforeRow = chessRow4;
            chessRow2[12].nextRow = chessRow3;
            chessRow2[0].beforeRow = chessRow1;
            chessRow3[12].nextRow = chessRow4;
            chessRow3[0].beforeRow = chessRow2;
            chessRow4[12].nextRow = chessRow1;
            chessRow4[0].beforeRow = chessRow3;

            chessRow1[10].LastRow = lastRowB;
            chessRow2[10].LastRow = lastRowY;
            chessRow3[10].LastRow = lastRowG;
            chessRow4[10].LastRow = lastRowR;

            chessRow1[4].fastpass = true;
            chessRow2[4].fastpass = true;
            chessRow3[4].fastpass = true;
            chessRow4[4].fastpass = true;
        }
        public ChessRowList ChessRow1
        {
            get { return chessRow1; }
        }
        public ChessRowList ChessRow2
        {
            get { return chessRow2; }
        }
        public ChessRowList ChessRow3
        {
            get { return chessRow3; }
        }
        public ChessRowList ChessRow4
        {
            get { return chessRow4; }
        }
        public ChessRowList LastRowR
        {
            get { return lastRowR; }
        }
        public ChessRowList LastRowB
        {
            get { return lastRowB; }
        }
        public ChessRowList LastRowY
        {
            get { return lastRowY; }
        }
        public ChessRowList LastRowG
        {
            get { return lastRowG; }
        }

    }
    public class ChessBock
    {
        private int color = 0;
        private int localx = 0;
        private int localy = 0;
        public Boolean fastpass = false;
        public int chessState = 0;
        public ChessRowList nextRow = null;
        public ChessRowList beforeRow = null;
        public ChessRowList LastRow = null;
        public Chess nowChess = null;
        public ChessBock(int x, int y, int c)
        {
            localx = x;
            localy = y;
            color = c;
        }
        public int Color
        {
            get {
                return color;
            }
            set {
                color = value;
            }
        }
        public int Localx
        {
            get {
                return localx;
            }
            set {
                localx = value;
            }
        }
        public int Localy
        {
            get {
                return localy;
            }
            set {
                localy = value;
            }
        }
    }
    public class ChessRowList : List<ChessBock>
    {
        private Boolean isLastRow = false;
        public Boolean IsLastRow
        {
            get {
                return isLastRow;
            }
            set {
                isLastRow = value;
            }
        }
    }
}
