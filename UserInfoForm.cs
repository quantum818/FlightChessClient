using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightChessClient
{
    public partial class UserInfoForm : Form
    {
        public UserInfoForm()
        {
            InitializeComponent();
        }

        private void UserInfoForm_Load(object sender, EventArgs e)
        {
            NameBox.ReadOnly = true;
            ClassBox.ReadOnly = true;
            ClassNameBox.ReadOnly = true;
            descriptionBox.ReadOnly = true;
            CreatTime.ReadOnly = true;
            NameBox.Text = utils.Userinfo.Username;
            ClassBox.Text = utils.Userinfo.Classnum.ToString();
            ClassNameBox.Text = utils.Userinfo.Classname;
            descriptionBox.Text = utils.Userinfo.Description;
            CreatTime.Text = utils.Userinfo.Logtime;
            SaveInfo.Enabled = false;
        }

        private void ChangeInfo_Click(object sender, EventArgs e)
        {
            NameBox.ReadOnly = false;
            descriptionBox.ReadOnly = false;
            SaveInfo.Enabled = true;
        }

        private void SaveInfo_Click(object sender, EventArgs e)
        {
            if (NameBox.TextLength != 0)
            {
                utils.Userinfo.Username = NameBox.Text.ToString();
                utils.Userinfo.Description = descriptionBox.Text.ToString();
                utils.Userinfo.infoUpata();
            }
            else
            {
                MessageBox.Show("用户名不能为空！");
            }
            NameBox.ReadOnly = true;
            descriptionBox.ReadOnly = true;
            SaveInfo.Enabled = false;
        }

        private void UserInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            utils.mainFrm.gameHall.ChangeInfoText();
        }
    }
}
