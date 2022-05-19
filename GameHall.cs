using Fleck;
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
    public partial class GameHall : Form
    {
        
        public GameHall()
        {
            InitializeComponent();
        }

        private void GameHall_Load(object sender, EventArgs e)
        { 
            this.MdiParent = utils.mainFrm;
            NameLAB.Text = NameLAB.Text + utils.Userinfo.Username;
            ClassLAB.Text = ClassLAB.Text + utils.Userinfo.Classnum.ToString();
            ClassGroupLAB.Text = ClassGroupLAB.Text + utils.Userinfo.Classname;
            desLAB.Text = desLAB.Text + utils.Userinfo.Description;
        }

        private void sendMsg_Click(object sender, EventArgs e)
        {
            JSONinfo jsonStr = new JSONinfo("chat", DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString(), utils.Userinfo.Username, MSGBox.Text.ToString());
            utils.mainFrm.SendMSG(jsonStr);
            MSGBox.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            utils.mainFrm.SendMSG(new JSONinfo("game", DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString(), utils.Userinfo.Username, "table1"));
        }
    }
}
