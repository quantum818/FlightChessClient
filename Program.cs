using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightChessClient
{
    static class Program
    {

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 login = new Form1();
            if (login.ShowDialog() == DialogResult.OK)
            {
                utils.mainFrm = new GameMain();
                Application.Run(utils.mainFrm);
            }
        }
    }
}
