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
        public static void mainWork(int userIndex, string login, string pass, string proxy)
        {
            req = Requests.Auth(login, pass, proxy);
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
            int goldLeft = 0;

            goldLeft = Requests.spendGold(req, spendType);

            if(spendType == 0)
            {
                while (goldLeft > 25)
                    goldLeft = Requests.spendGold(req, spendType);
            }
            else if (spendType == 1)
            {
                while (goldLeft > 75)
                    goldLeft = Requests.spendGold(req, spendType);
            }
            else
            {
                MessageBox.Show("Не смеши людей, у тебя нет золота");
            }

            MessageBox.Show("Трата золота окончена");
        }

        public static void patrol(int index, int time)
        {
            string s = Requests.goToPatrol(req, time);
            MessageBox.Show(s);
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