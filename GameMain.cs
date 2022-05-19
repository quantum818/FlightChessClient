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
    public partial class GameMain : Form
    {
        public ClientWebSocket clientWebSocket = new ClientWebSocket();
        private delegate void SafeWriteDelegate(string text);
        private delegate void SafeOpenDelegate();
        private delegate void SafeCloseDelegate();
        public string RevMSG = "";
        public JSONinfo TsJSON = new JSONinfo();
        private ThreadStart listeningService;
        private Thread listening;
        private Game game = null;
        private GameHall gameHall = null;
        public GameMain()
        {
            InitializeComponent();
        }

        private void GameMain_Load(object sender, EventArgs e)
        {
            utils.Userinfo.updataLoginfo();
            gameHall = new GameHall();
            game = new Game();
            clientWebSocket.ConnectAsync(new Uri("ws://127.0.0.1:9001"), CancellationToken.None).Wait();
            listeningService = new ThreadStart(GetMSG);
            listening = new Thread(listeningService);
            listening.Start();
            gameHall.Show();
        }
        private void GetMSG()
        {
            while (true)
            {
                if (clientWebSocket.State == WebSocketState.Open)
                {
                    var buffer = new byte[1024];
                    ArraySegment<byte> bytesToRev = new ArraySegment<byte>(buffer);
                    var res = clientWebSocket.ReceiveAsync(bytesToRev, CancellationToken.None).Result;
                    string temp = Encoding.UTF8.GetString(buffer, 0, res.Count);
                    System.Console.WriteLine(temp);
                    if (!RevMSG.Equals(temp) && temp != "new client connect!")
                    {
                        JavaScriptSerializer jss = new JavaScriptSerializer();
                        TsJSON = jss.Deserialize<JSONinfo>(temp);
                        RevMSG = temp;
                        if (TsJSON.MSGKind == "chat")
                        {
                            WriteTextSafe("(" + TsJSON.timeNow + ")" + TsJSON.sendHost + "：" + TsJSON.MSG + "\r\n");
                        }
                        else if (TsJSON.MSGKind == "game")
                        {
                            if (TsJSON.MSG == "start")
                            {
                                OpenFormSafe();
                                listening.Abort();
                            }
                        }
                    }
                }
            }
        }
        public void SendMSG(JSONinfo ind)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            string sendJson = jss.Serialize(ind);
            ArraySegment<byte> bytesToSend = new ArraySegment<byte>(Encoding.UTF8.GetBytes(sendJson));
            clientWebSocket.SendAsync(bytesToSend, WebSocketMessageType.Text, true, CancellationToken.None).Wait();
        }
        private void OpenFormSafe()
        {
            if (game.InvokeRequired)
            {
                var d = new SafeOpenDelegate(OpenFormSafe);
            }
            else
            {
                game.ShowDialog();
            }
        }
        private void CloseFormSafe()
        {
            if (gameHall.InvokeRequired)
            {
                var d = new SafeCloseDelegate(CloseFormSafe);
            }
            else
            {
                gameHall.Close();
            }
        }
        private void WriteTextSafe(string text)
        {
            if (gameHall.ChatRoom.InvokeRequired)
            {
                var d = new SafeWriteDelegate(WriteTextSafe);
                gameHall.ChatRoom.Invoke(d, new object[] { text });
            }
            else
            {
                gameHall.ChatRoom.Text += text;
            }
        }

        private void GameMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            listening.Abort();
            System.Environment.Exit(0);
        }
    }
}
