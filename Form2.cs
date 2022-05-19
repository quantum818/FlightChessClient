using MySql.Data.MySqlClient;
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
    public partial class registerF : Form
    {
        public registerF()
        {
            InitializeComponent();
        }

        private void register_b_Click(object sender, EventArgs e)
        {
            if (UserNameBox.Text.Length == 0)
            {
                MessageBox.Show("用户名不能为空");
            }
            else if (PassWordBox.Text.Length == 0)
            {
                MessageBox.Show("密码不能为空");
            }
            else if (RePassWordBox.Text.ToString() != PassWordBox.Text.ToString())
            {
                MessageBox.Show("两次密码不匹配");
            }
            else
            {
                String connStr = utils.connStr;
                MySqlConnection connection = new MySqlConnection(connStr);
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("无法连接至服务器");
                }
                if (connection.State == ConnectionState.Open)
                {
                    string sltStr = "INSERT INTO Loginfo (password,username,datein,classname,classnum) VALUES(" + "'" + PassWordBox.Text.ToString() + "'," + "'" + UserNameBox.Text.ToString() + "'," + "now()," + "'新手伞兵'," + "'1'); ";
                    MySqlCommand cmd = new MySqlCommand(sltStr, connection);
                    int res = cmd.ExecuteNonQuery();
                    if (res == 1)
                    {
                        MessageBox.Show("注册成功");
                        connection.Close();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("注册失败");
                    }
                }
            }
        }
    }
}
