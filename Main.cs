using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet.Net;

namespace RoswarHelper
{
    public class Main
    {
        public static HttpRequest req;
        public static void mainWork(int userIndex, string login, string pass, TextBox textBox1)
        {
            req = Requests.Auth(login, pass, textBox1);
            //MessageBox.Show(acc.ToString());
        }
        public static void selectedAcc(int index)
        {
        }
        public static void goTo(int index)
        {
            Requests.restoreHP(req);
        }
        public static void spendGold(int index, int spendType)
        {
            int goldLeft = Requests.spendGold(req, spendType);
            MessageBox.Show(goldLeft.ToString());
        }
        public static void showInfo()
        {
        }
        public static void waitMht(int sec) //wait for complite load page
        {
            DateTime Tthen = DateTime.Now;
            do
            {
                Application.DoEvents();
            }
            while (Tthen.AddSeconds(sec) > DateTime.Now);
        }
    }
}