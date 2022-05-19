using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FlightChessClient
{
    public partial class Form1 : Form
    {
        string connStr = utils.connStr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (UserNameBox.Text.Length != 0 && PassWordBox.Text.Length != 0)
            {
                MySqlConnection connection = new MySqlConnection(connStr);
                try
                {
                    connection.Open();
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show("无法连接至服务器");
                }
                if (connection.State == ConnectionState.Open)
                {
                    DataSet temp = new DataSet();
                    String sltStr = "select password from Loginfo where username = " + "'" + UserNameBox.Text.ToString() + "';";
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sltStr, connection);
                    MySqlCommandBuilder mySqlCommandBuilder = new MySqlCommandBuilder(dataAdapter);
                    dataAdapter.Fill(temp, "temptb");
                    connection.Close();
                    DataTable table = temp.Tables["temptb"];
                    if (table.Rows.Count==0)
                    {
                        MessageBox.Show("用户不存在");
                    }
                    else
                    {
                        DataRow data = table.Rows[0];
                        string getstr = data.ItemArray[0].ToString();
                        if (PassWordBox.Text.ToString().Equals(getstr))
                        {
                            utils.Userinfo.Username = UserNameBox.Text.ToString();
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("密码错误");
                        }
                    }
                }
            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            registerF register = new registerF();
            register.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
