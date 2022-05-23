using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using static FlightChessClient.utils;

namespace FlightChessClient
{
    public partial class Game : Form
    {
        private Button myDice = null;
        public int round = 0;
        private ThreadStart listeningService;
        private Thread listening;
        private delegate void SafeAddDelegate(Form ind);
        private delegate void SafeOpenDelegate(Form parent);
        private delegate void SafeDiceOp(Boolean en);
        private delegate void SafeTextChange(String ind);
        private delegate void SafeAddObj(Chess ind);
        private int points = 0;
        private int WinChesses = 0;
        private int sixTimes = 0;
        private Boolean isFirstSix = false;
        private Boolean REVMSG = false;
        private List<Chess> WaitArea = new List<Chess>();
        public ChessBoard board = new ChessBoard();
        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            switch (round)
            {
                case 1: myDice = YellowDice; break;
                case 2: myDice = GreenDice; break;
                case 3: myDice = RedDice; break;
                case 4: myDice = BlueDice; break;
                default: break;
            }
            int i = 0;
            foreach (var player in utils.mainFrm.players)
            {
                if (i == 0)
                {
                    YellowTeam.Text = player;
                    foreach (Chess chess in YellowTeam.Controls.OfType<Chess>())
                    {
                        chess.host = player;
                        chess.ChessColor = i;
                        chess.LastRow = board.LastRowY;
                    }
                }
                else if (i == 1)
                {
                    GreenTeam.Text = player;
                    foreach (Chess chess in GreenTeam.Controls.OfType<Chess>())
                    {
                        chess.host = player;
                        chess.ChessColor = i;
                        chess.LastRow = board.LastRowG;
                    }
                }
                else if (i == 2)
                {
                    RedTeam.Text = player;
                    foreach (Chess chess in RedTeam.Controls.OfType<Chess>())
                    {
                        chess.host = player;
                        chess.ChessColor = i;
                        chess.LastRow = board.LastRowR;
                    }
                }
                else if (i == 3)
                {
                    BlueTeam.Text = player;
                    foreach (Chess chess in BlueTeam.Controls.OfType<Chess>())
                    {
                        chess.host = player;
                        chess.ChessColor = i;
                        chess.LastRow = board.LastRowB;
                    }
                }
                i++;
            }
            YellowDice.Enabled = false;
            GreenDice.Enabled = false;
            RedDice.Enabled = false;
            BlueDice.Enabled = false;
            listeningService = new ThreadStart(GetMSG);
            listening = new Thread(listeningService);
            listening.Start();
            if (round == 1) myDice.Enabled = true;
            foreach (var chess in BlueTeam.Controls.OfType<Chess>())
            {
                chess.OrginImage = chess.Image;
                chess.ChessColor = 2;
                chess.ChessOrigin = chess.Location;
                chess.nowRow = board.ChessRow3;
                chess.startRow = board.ChessRow3;
                chess.parentBox = BlueTeam;
                chess.ChessStartArea = new Point(197, 472);
            }
            foreach (var chess in RedTeam.Controls.OfType<Chess>())
            {
                chess.OrginImage = chess.Image;
                chess.ChessColor = 1;
                chess.ChessOrigin = chess.Location;
                chess.nowRow = board.ChessRow2;
                chess.startRow = board.ChessRow2;
                chess.parentBox = RedTeam;
                chess.ChessStartArea = new Point(624, 472);
            }
            foreach (var chess in GreenTeam.Controls.OfType<Chess>())
            {
                chess.OrginImage = chess.Image;
                chess.ChessColor = 0;
                chess.ChessOrigin = chess.Location;
                chess.nowRow = board.ChessRow1;
                chess.startRow = board.ChessRow1;
                chess.parentBox = GreenTeam;
                chess.ChessStartArea = new Point(624, 43);
            }
            foreach (var chess in YellowTeam.Controls.OfType<Chess>())
            {
                chess.OrginImage = chess.Image;
                chess.ChessColor = 3;
                chess.ChessOrigin = chess.Location;
                chess.nowRow = board.ChessRow4;
                chess.startRow = board.ChessRow4;
                chess.parentBox = YellowTeam;
                chess.ChessStartArea = new Point(197, 43);
            }
        }
        public void OpenFormSafe(Form parent)
        {
            if (parent.InvokeRequired)
            {
                var d = new SafeOpenDelegate(OpenFormSafe);
                parent.Invoke(d, new object[] { parent });
            }
            else
            {
                this.ShowDialog(parent);
            }
        }
        public void AddObjSafe(Chess ind)
        {
            if (this.InvokeRequired)
            {
                var d = new SafeAddObj(AddObjSafe);
                this.Invoke(d, new object[] { ind });
            }
            else
            {
                this.Controls.Add(ind);
            }
        }
        public void ChangeTextSafe(String ind)
        {
            if (GameInfo.InvokeRequired)
            {
                var d = new SafeTextChange(ChangeTextSafe);
                GameInfo.Invoke(d, new object[] { ind });
            }
            else
            {
                this.GameInfo.Text = "对战中：" + ind;
            }
        }
        private void GetMSG()
        {
            while (true)
            {
                if (utils.mainFrm.clientWebSocket.State == WebSocketState.Open)
                {
                    var buffer = new byte[1024];
                    ArraySegment<byte> bytesToRev = new ArraySegment<byte>(buffer);
                    var res = utils.mainFrm.clientWebSocket.ReceiveAsync(bytesToRev, CancellationToken.None).Result;
                    string temp = Encoding.UTF8.GetString(buffer, 0, res.Count);
                    System.Console.WriteLine(temp);
                    Chessinfo chessinfo = new Chessinfo();
                    Commd commd = new Commd();
                    WinInfo winInfo = new WinInfo();
                    JavaScriptSerializer jss = new JavaScriptSerializer();
                    if (temp == utils.Userinfo.Username)
                    {
                        SafeEnableDice(true);
                    }
                    try
                    {
                        chessinfo = jss.Deserialize<Chessinfo>(temp);
                    }
                    catch { }
                    try
                    {
                        commd = jss.Deserialize<Commd>(temp);
                    }
                    catch { }
                    try
                    {
                        winInfo = jss.Deserialize<WinInfo>(temp);
                    }
                    catch { }
                    if (chessinfo.MSGKind == "Chess" && chessinfo.sendHost != utils.Userinfo.Username)
                    {
                        if (chessinfo.States == 1)
                        {
                            GroupBox tempBox = null;
                            Chess REVChess = null;
                            foreach (var box in this.Controls.OfType<GroupBox>())
                            {
                                if (box.Text == chessinfo.sendHost)
                                {
                                    tempBox = box;
                                    break;
                                }
                            }
                            foreach (var chess in tempBox.Controls.OfType<Chess>())
                            {
                                if (chess.Name == chessinfo.ChessName)
                                {
                                    REVChess = chess;
                                    break;
                                }
                            }
                            AddObjSafe(REVChess);
                            REVChess.parentBox.SendToBack();
                            REVChess.Location = REVChess.ChessStartArea;
                            REVChess.parentBox.BringToFront();
                            isFirstSix = true;
                            REVChess.Parent = this.pictureBox1;
                        }
                        else if (chessinfo.States == 2)
                        {
                            Chess REVChess = null;
                            foreach (var chess in pictureBox1.Controls.OfType<Chess>())
                            {
                                if (chess.Name == chessinfo.ChessName)
                                {
                                    REVChess = chess;
                                    break;
                                }
                            }
                            if (!REVChess.isChange)
                            {
                                REVChess.Width = REVChess.Width / 2;
                                REVChess.Height = REVChess.Height / 2;
                                REVChess.isChange = true;
                            }
                            if (REVChess.nowRow != null)
                            {
                                REVChess.nowRow[REVChess.nowLocal].nowChess = null;
                            }
                            REVChess.getRow(chessinfo.ChessRow, board);
                            REVChess.nowLocal = chessinfo.ChessLocal;
                            REVChess.Location = new Point(REVChess.nowRow[REVChess.nowLocal].Localx - 20, REVChess.nowRow[REVChess.nowLocal].Localy - 20);
                            CheckChesses(REVChess.nowRow[REVChess.nowLocal], REVChess);
                        }
                        else if (chessinfo.States == 3 && chessinfo.ChessRow==-1)
                        {
                            Chess REVChess = null;
                            foreach (var chess in pictureBox1.Controls.OfType<Chess>())
                            {
                                if (chess.Name == chessinfo.ChessName)
                                {
                                    REVChess = chess;
                                    break;
                                }
                            }
                            foreach (var chess in REVChess.otherChess)
                            {
                                chess.Show();
                                chess.Image = chess.OrginImage;
                                chess.parentBox.Controls.Add(chess);
                                chess.Parent = chess.parentBox;
                                chess.Location = chess.ChessOrigin;
                                chess.Width = chess.Width * 2;
                                chess.Height = chess.Height * 2;
                                chess.isChange = false;
                                chess.nowRow = chess.startRow;
                                chess.nowLocal = 0;
                                chess.isStart = false;
                            }
                            REVChess.otherChess.Clear();
                            REVChess.otherChess.Add(REVChess);
                        }
                    }
                    if (chessinfo.MSGKind == "Chess" && chessinfo.States == 3 && chessinfo.ChessRow != -1)//此处更改为单次条件控制解决单边显示问题，未验证
                    {
                        ChangeTextSafe(chessinfo.sendHost + "击坠了" + chessinfo.ChessName + " " + chessinfo.ChessRow + "架飞机！");
                    }
                    else if (commd.MSGKind == "Comm")
                    {
                        if (commd.Host == utils.Userinfo.Username)
                        {
                            points = commd.DicePoint;
                            REVMSG = true;
                        }
                        ChangeTextSafe(commd.Host + "掷出了" + commd.DicePoint.ToString() + "点！");
                    }
                    else if (winInfo.MSGKind == "WinInfo" && winInfo.WinChess == 4)
                    {
                        ChangeTextSafe(winInfo.Host + "赢了");
                    }
                }
            }
        }

        private void SafeEnableDice(Boolean en)
        {
            if (myDice.InvokeRequired)
            {
                var d = new SafeDiceOp(SafeEnableDice);
                myDice.Invoke(d, new object[] { en });
            }
            else
            {
                this.myDice.Enabled = true;
            }
        }

        private void YellowDice_Click(object sender, EventArgs e)
        {
            CommonClick();
        }

        private void GreenDice_Click(object sender, EventArgs e)
        {
            CommonClick();
        }

        private void RedDice_Click(object sender, EventArgs e)
        {
            CommonClick();
        }

        private void BlueDice_Click(object sender, EventArgs e)
        {
            CommonClick();
        }
        private void CommonClick()
        {
            utils.mainFrm.SendStr(round.ToString());
            while (!REVMSG) { }
            if (points == 6)
            {
                sixTimes++;
            }
            if (points != 6 || sixTimes == 2)
            {
                sixTimes = 0;
                utils.mainFrm.SendStr("C");
                myDice.Enabled = false;
            }
            REVMSG = false;
        }

        private void Chess_Click(object sender, EventArgs e)
        {
            Chess thisChess = (Chess)sender;
            ChessToMove(thisChess);
            if (thisChess.isStart)
            {
                Chessinfo sendChessPosition = null;
                if (thisChess.nowLocal == -1)
                {
                    int temp = thisChess.localRow(board) - 1;
                    if (temp == 0) temp = 4;
                    sendChessPosition = new Chessinfo("Chess", utils.Userinfo.Username, thisChess.Name, temp, 12, 2);
                    CheckChesses(thisChess.nowRow[0].beforeRow[12], thisChess);
                }
                else
                {
                    sendChessPosition = new Chessinfo("Chess", utils.Userinfo.Username, thisChess.Name, thisChess.localRow(board), thisChess.nowLocal, 2);
                    CheckChesses(thisChess.nowRow[thisChess.nowLocal], thisChess);
                }
                utils.mainFrm.SendChessMSG(sendChessPosition);
            }
        }
        private void CheckChesses(ChessBock bock, Chess ind)
        {
            if (bock.nowChess != null && bock.nowChess.ChessColor == ind.ChessColor)
            {
                foreach (var chess in bock.nowChess.otherChess)
                {
                    ind.otherChess.Add(chess);
                }
                bock.nowChess.Hide();
                int nowChess = ind.otherChess.Count();
                if (ind.parentBox == BlueTeam)
                {
                    switch (nowChess)
                    {
                        case 2: ind.Image = FlightChessClient.Properties.Resources.chessB2; break;
                        case 3: ind.Image = FlightChessClient.Properties.Resources.chessB3; break;
                        case 4: ind.Image = FlightChessClient.Properties.Resources.chessB4; break;
                        default: break;
                    }
                }
                else if (ind.parentBox == RedTeam)
                {
                    switch (nowChess)
                    {
                        case 2: ind.Image = FlightChessClient.Properties.Resources.chessR2; break;
                        case 3: ind.Image = FlightChessClient.Properties.Resources.chessR3; break;
                        case 4: ind.Image = FlightChessClient.Properties.Resources.chessR4; break;
                        default: break;
                    }
                }
                else if (ind.parentBox == YellowTeam)
                {
                    switch (nowChess)
                    {
                        case 2: ind.Image = FlightChessClient.Properties.Resources.chessY2; break;
                        case 3: ind.Image = FlightChessClient.Properties.Resources.chessY3; break;
                        case 4: ind.Image = FlightChessClient.Properties.Resources.chessY4; break;
                        default: break;
                    }
                }
                else if (ind.parentBox == GreenTeam)
                {
                    switch (nowChess)
                    {
                        case 2: ind.Image = FlightChessClient.Properties.Resources.chessG2; break;
                        case 3: ind.Image = FlightChessClient.Properties.Resources.chessG3; break;
                        case 4: ind.Image = FlightChessClient.Properties.Resources.chessG4; break;
                        default: break;
                    }
                }
            }
            else if (bock.nowChess != null && bock.nowChess.ChessColor != ind.ChessColor&&ind.host==utils.Userinfo.Username)
            {
                Chessinfo sendMSG = new Chessinfo("Chess", utils.Userinfo.Username, bock.nowChess.host, bock.nowChess.otherChess.Count, -1, 3);
                goBackHome(bock.nowChess);
                utils.mainFrm.SendChessMSG(sendMSG);
            }
            bock.nowChess = ind;
        }
        private void ChessToMove(Chess temp)
        {
            if (!temp.isStart)
            {
                if (!WaitArea.Contains(temp))
                {
                    isFirstSix = false;
                }
                else
                {
                    isFirstSix = true;
                }
            }
            if (!temp.isStart) CheckChessStart(temp);
            if (temp.isStart)
            {
                if (temp.nowLocal == -1) temp.nowRow[0].beforeRow[12].nowChess = null;
                else temp.nowRow[temp.nowLocal].nowChess = null;
                if (!temp.inLast)
                {
                    temp.nowLocal += points;
                    if (!temp.isChange)
                    {
                        temp.Width = temp.Width / 2;
                        temp.Height = temp.Height / 2;
                        temp.isChange = true;
                        temp.nowLocal--;
                    }
                    ChessMove(temp);
                    //跳子判断
                    if (!temp.inLast && temp.ChessColor == temp.nowRow[temp.nowLocal].Color)
                    {
                        temp.nowRow[temp.nowLocal].nowChess = null;
                        temp.nowLocal += 4;
                        ChessMove(temp);
                    }
                    //图连通判断
                    if (temp.nowLocal == 12)
                    {
                        temp.nowRow[temp.nowLocal].nowChess = null;
                        temp.nowRow = temp.nowRow[12].nextRow;
                        temp.nowLocal = -1;
                    }
                }
                else
                {
                    temp.nowRow[temp.nowLocal].nowChess = null;
                    if (temp.nowRow[temp.nowLocal].LastRow == null)
                    {
                        temp.nowLocal += points;
                        if (temp.nowLocal > 5)
                        {
                            temp.nowLocal = 6 - (temp.nowLocal - 6) - 2;
                            temp.Location = new Point(temp.nowRow[temp.nowLocal].Localx - 20, temp.nowRow[temp.nowLocal].Localy - 20);
                            System.Console.WriteLine(temp.Location.X.ToString() + " " + temp.Location.Y.ToString());
                        }
                        else if (temp.nowLocal == 5)
                        {
                            temp.Location = new Point(temp.nowRow[temp.nowLocal].Localx - 20, temp.nowRow[temp.nowLocal].Localy - 20);
                            sendWinInfo(temp);
                        }
                        else
                        {
                            temp.Location = new Point(temp.nowRow[temp.nowLocal].Localx - 20, temp.nowRow[temp.nowLocal].Localy - 20);
                            System.Console.WriteLine(temp.Location.X.ToString() + " " + temp.Location.Y.ToString());
                        }
                    }
                    else
                    {
                        temp.nowRow = temp.nowRow[temp.nowLocal].LastRow;
                        temp.nowLocal = -1;
                        temp.nowLocal += points;
                        temp.Location = new Point(temp.nowRow[temp.nowLocal].Localx - 20, temp.nowRow[temp.nowLocal].Localy - 20);
                        System.Console.WriteLine(temp.Location.X.ToString() + " " + temp.Location.Y.ToString());
                        if (temp.nowLocal == 5)
                        {
                            temp.Location = new Point(temp.nowRow[temp.nowLocal].Localx - 20, temp.nowRow[temp.nowLocal].Localy - 20);
                            sendWinInfo(temp);
                        }
                    }
                }
            }
        }
        private void ChessMove(Chess ind)
        {
            if (ind.nowLocal - points >= 5 && ind.nowLocal - points <= 10 && ind.nowLocal != 6)
            {
                for (int j = ind.nowLocal - points; j <= ind.nowLocal; j++)
                {
                    if (j <= 10 && ind.nowRow[j].LastRow != null && ind.nowRow[j].Color == ind.ChessColor)
                    {
                        ind.inLast = true;
                        if (j < ind.nowLocal)
                        {
                            ind.nowRow = ind.nowRow[j].LastRow;
                            ind.nowLocal = ind.nowLocal - j - 1;
                            ind.Location = new Point(ind.nowRow[ind.nowLocal].Localx - 20, ind.nowRow[ind.nowLocal].Localy - 20);
                            System.Console.WriteLine(ind.Location.X.ToString() + " " + ind.Location.Y.ToString());
                        }
                        else
                        {
                            ind.Location = new Point(ind.nowRow[ind.nowLocal].Localx - 20, ind.nowRow[ind.nowLocal].Localy - 20);
                            System.Console.WriteLine(ind.Location.X.ToString() + " " + ind.Location.Y.ToString());
                        }
                        return;
                    }
                }
            }
            if (ind.nowLocal > 12)
            {
                ind.nowRow = ind.nowRow[12].nextRow;
                ind.nowLocal = ind.nowLocal - 12 - 1;
            }
            //虚线航线判断
            if (ind.nowRow[ind.nowLocal].fastpass && ind.ChessColor == ind.nowRow[ind.nowLocal].Color)
            {
                ind.nowLocal = 3;
                ind.nowRow = ind.nowRow[12].nextRow;
            }
            ind.Location = new Point(ind.nowRow[ind.nowLocal].Localx - 20, ind.nowRow[ind.nowLocal].Localy - 20);
        }
        private void CheckChessStart(Chess ind)
        {
            if (points == 6 && !isFirstSix)
            {
                this.Controls.Add(ind);
                ind.parentBox.SendToBack();
                ind.parentBox.BringToFront();
                isFirstSix = true;
                pictureBox1.Controls.Add(ind);
                ind.Parent = this.pictureBox1;
                CheckWaitArea();
                WaitArea.Add(ind);
                ind.Location = ind.ChessStartArea;
                Chessinfo sendStartInfo = new Chessinfo("Chess", utils.Userinfo.Username, ind.Name, -1, -1, 1);
                utils.mainFrm.SendChessMSG(sendStartInfo);
                return;
            }
            if (isFirstSix && !ind.isStart)
            {
                ind.isStart = true;
                isFirstSix = false;
                WaitArea.Remove(ind);
                DispordWaitArea();
            }
        }
        private void CheckWaitArea()
        {
            if (WaitArea.Count != 0)
            {
                foreach (var chess in WaitArea)
                {
                    chess.Enabled = false;
                }
            }
        }
        private void DispordWaitArea()
        {
            if (WaitArea.Count != 0)
            {
                WaitArea.Last<Chess>().Enabled = true;
            }
            pictureBox1.SendToBack();
        }
        private void sendWinInfo(Chess chess)
        {
            WinChesses += chess.otherChess.Count();
            WinInfo msg = new WinInfo("WinInfo", utils.Userinfo.Username, WinChesses);
            utils.mainFrm.SendWinMSG(msg);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine(MousePosition.X.ToString() + "," + MousePosition.Y.ToString());
        }
        //
        //回家
        //
        private void goBackHome(Chess ind)
        {
            foreach (var chess in ind.otherChess)
            {
                chess.Show();
                chess.Image = chess.OrginImage;
                chess.parentBox.Controls.Add(chess);
                chess.Parent = chess.parentBox;
                chess.Location = chess.ChessOrigin;
                chess.Width = chess.Width * 2;
                chess.Height = chess.Height * 2;
                chess.isChange = false;
                chess.nowRow = chess.startRow;
                chess.nowLocal = 0;
                chess.isStart = false;
            }
            ind.otherChess.Clear();
            ind.otherChess.Add(ind);
            Chessinfo sendBackhomeinfo = new Chessinfo("Chess", utils.Userinfo.Username, ind.Name, -1, -1, 3);
            utils.mainFrm.SendChessMSG(sendBackhomeinfo);
        }
    }
}
