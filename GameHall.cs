using Fleck;
using MySql.Data.MySqlClient;
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
            JSONinfo jsonStr = new JSONinfo("chat", DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString(), utils.Userinfo.Username, MSGBox.Text.ToString(),0);
            utils.mainFrm.SendMSG(jsonStr);
            MSGBox.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            utils.mainFrm.RoomID = 1;
            RoomInfo.Visible = true;
            utils.mainFrm.SendMSG(new JSONinfo("game", DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString(), utils.Userinfo.Username, "table1",1));
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

        private void PlayerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();
            DataSet temp = new DataSet();
            String username = PlayerBox.SelectedItem.ToString();
            String classname = "", description = "", logtime = "";
            int classnum = 0;
            String sltStr = "select classname,classnum,description,datein,account from Loginfo where username = " + "'" + username + "';";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sltStr, connection);
            MySqlCommandBuilder mySqlCommandBuilder = new MySqlCommandBuilder(dataAdapter);
            dataAdapter.Fill(temp, "temptb");
            connection.Close();
            DataTable table = temp.Tables["temptb"];
            DataRow tempRow = table.Rows[0];
            int count = 0;
            foreach (var data in tempRow.ItemArray)
            {
                switch (count)
                {
                    case 0: classname = data.ToString(); break;
                    case 1: classnum = int.Parse(data.ToString()); break;
                    case 2: description = data.ToString(); break;
                    case 3: logtime = data.ToString(); break;
                    default: break;
                }
                count++;
            }
            MessageBox.Show("等级：" + classnum.ToString() + "\r\n" + "称号：" + classname + "\r\n" + "注册时间：" + logtime + "\r\n" + "个性签名：" + description, username);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            utils.mainFrm.RoomID = 2;
            RoomInfo.Visible = true;
            utils.mainFrm.SendMSG(new JSONinfo("game", DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString(), utils.Userinfo.Username, "table2",2));
            RoomInfo.Text += DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString() + " " + "你进入了房间2\r\n";
        }
    }
}
