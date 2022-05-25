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
            RoomInfo.Visible = false;
            this.MdiParent = utils.mainFrm;
            ChangeInfoText();
        }

        private void sendMsg_Click(object sender, EventArgs e)
        {
            JSONinfo jsonStr = new JSONinfo("chat", DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString(), utils.Userinfo.Username, MSGBox.Text.ToString());
            utils.mainFrm.SendMSG(jsonStr);
            MSGBox.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            RoomInfo.Visible = true;
            utils.mainFrm.SendMSG(new JSONinfo("game", DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString(), utils.Userinfo.Username, "table1"));
            RoomInfo.Text += DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString() + " " + "你进入了房间1\r\n";
        }

        private void personalInfo_Click(object sender, EventArgs e)
        {
            UserInfoForm infoForm = new UserInfoForm();
            infoForm.MdiParent = utils.mainFrm;
            infoForm.Show();
        }
        public void ChangeInfoText()
        {
            NameLAB.Text = "昵称: " + utils.Userinfo.Username;
            ClassLAB.Text = "等级: " + utils.Userinfo.Classnum.ToString();
            ClassGroupLAB.Text = "称号: " + utils.Userinfo.Classname;
            desLAB.Text = "个性签名: " + utils.Userinfo.Description;
        }
    }
}
