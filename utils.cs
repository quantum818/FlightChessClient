using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace FlightChessClient
{
    public class utils
    {
        public static string connStr = "Database=zqpData;Data Source=madoka.higuchi.xyz;port=3306;User Id=root;Password=tieo;";
        public static GameMain mainFrm = null;
        public static class Userinfo
        {
            private static string username = "";
            private static string classname = "";
            private static int classnum;
            private static string description = "";
            private static string logtime = "";
            private static long account = 0;
            public static string Username
            {
                get {
                    return username;
                }
                set {
                    username = value;
                }
            }
            public static string Classname
            {
                get {
                    return classname;
                }
                set {
                    classname = value;
                }
            }
            public static int Classnum
            {
                get {
                    return classnum;
                }
                set {
                    classnum = value;
                }
            }
            public static string Description
            {
                get {
                    return description;
                }
                set {
                    description = value;
                }
            }
            public static string Logtime
            {
                get {
                    return logtime;
                }
                set {
                    logtime = value;
                }
            }
            public static void updataLoginfo()
            {
                MySqlConnection connection = new MySqlConnection(connStr);
                connection.Open();
                DataSet temp = new DataSet();
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
                        case 4: account = int.Parse(data.ToString()); break;
                        default: break;
                    }
                    count++;
                }
            }
            public static int infoUpata()
            {
                MySqlConnection connection = new MySqlConnection(connStr);
                connection.Open();
                string sltStr = "update Loginfo set description ='" + description + "'" + ",username='" + username + "' where account=" + "'" + account + "';";//需要修改更改完后的database检索条件
                MySqlCommand cmd = new MySqlCommand(sltStr, connection);
                int res = cmd.ExecuteNonQuery();
                connection.Close();
                return res;
            }
            public static void classUpata()
            {
                MySqlConnection connection = new MySqlConnection(connStr);
                connection.Open();
                string sltStr = "update Loginfo set classnum ='" + classnum.ToString() + "' where username=" + "'" + username + "';";
                MySqlCommand cmd = new MySqlCommand(sltStr, connection);
                int res = cmd.ExecuteNonQuery();
                if (classnum >= 10 && classnum < 25 && classname != "初级炮灰")
                {
                    classname = "初级炮灰";
                    sltStr = "update Loginfo set classname ='" + classnum.ToString() + "' where username=" + "'" + username + "';";
                    cmd = new MySqlCommand(sltStr, connection);
                    res = cmd.ExecuteNonQuery();
                }
                else if (classnum >= 25 && classnum < 40 && classname != "中级炮灰")
                {
                    classname = "中级炮灰";
                    sltStr = "update Loginfo set classname ='" + classnum.ToString() + "' where username=" + "'" + username + "';";
                    cmd = new MySqlCommand(sltStr, connection);
                    res = cmd.ExecuteNonQuery();
                }
                else if (classnum >= 40 && classnum < 50 && classname != "高级炮灰")
                {
                    classname = "高级炮灰";
                    sltStr = "update Loginfo set classname  ='" + classnum.ToString() + "' where username=" + "'" + username + "';";
                    cmd = new MySqlCommand(sltStr, connection);
                    res = cmd.ExecuteNonQuery();
                }
                else if (classnum >= 50 && classnum < 60 && classname != "终级炮灰")
                {
                    classname = "终级炮灰";
                    sltStr = "update Loginfo set classname  ='" + classnum.ToString() + "' where username=" + "'" + username + "';";
                    cmd = new MySqlCommand(sltStr, connection);
                    res = cmd.ExecuteNonQuery();
                }
                else if (classnum >= 60 && classnum<75 && classname != "新米飞行员")
                {
                    classname = "新米飞行员";
                    sltStr = "update Loginfo set classname ='" + classnum.ToString() + "' where username=" + "'" + username + "';";
                    cmd = new MySqlCommand(sltStr, connection);
                    res = cmd.ExecuteNonQuery();
                }
                else if (classnum >= 75 && classnum < 80 && classname != "米娜·底特瑞奇·威欧克")
                {
                    classname = "米娜·底特瑞奇·威欧克";
                    sltStr = "update Loginfo set classname  ='" + classnum.ToString() + "' where username=" + "'" + username + "';";
                    cmd = new MySqlCommand(sltStr, connection);
                    res = cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public class JSONinfo
        {
            public String MSGKind = "";
            public String timeNow = "";
            public String sendHost = "";
            public String MSG = "";
            public JSONinfo(String msgKind,String time,String userName,String msg)
            {
                MSGKind = msgKind;
                timeNow = time;
                sendHost = userName;
                MSG = msg;
            }
            public JSONinfo()
            {

            }
        }
        public class Chessinfo
        {
            public String MSGKind = "";
            public String sendHost = "";
            public String ChessName = "";
            public int ChessRow = -1;
            public int ChessLocal = -1;
            public int States = -1;
            public Chessinfo(String msgKind,String userName,String chessName,int chessRow,int chessLocal,int states)
            {
                MSGKind = msgKind;
                sendHost = userName;
                ChessName = chessName;
                ChessRow = chessRow;
                ChessLocal = chessLocal;
                States = states;
            }
            public Chessinfo()
            {

            }
        }
        public class Commd
        {
            public String MSGKind = "";
            public int DicePoint = -1;
            public Boolean DiceState = false;
            public String Host = "";
            public int roomID = -1;
        }
        public class WinInfo
        {
            public String MSGKind = "";
            public String Host = "";
            public int WinChess = -1;
            public WinInfo(String msgKind,String host,int chesses)
            {
                MSGKind = msgKind;
                Host = host;
                WinChess = chesses;
            }
            public WinInfo()
            {

            }
        }
    }
}
