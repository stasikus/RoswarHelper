﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoswarHelper
{
    public class Main
    {
        private static Dictionary<int, WebBrowser> webBrowsersDic = new Dictionary<int, WebBrowser>();
        //public static Form1 form1 = new Form1();

        public static void mainWork(int userIndex, string login, string pass, string prFromLists)
        {
            //string key = "Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings"; //установка прокси
            //string port = "80"; 
            //string proxy = prFromLists + ":" + port;
            //RegistryKey RegKey = Registry.CurrentUser.OpenSubKey(key, true);
            //RegKey.SetValue("ProxyServer", proxy);
            //RegKey.SetValue("ProxyEnable", 1);
            //waitMht(1);

            WebBrowser webBrowser = new WebBrowser();
            webBrowser.ScriptErrorsSuppressed = true;
            webBrowser.Navigate("http://www.roswar.ru");
            waitMht(1);
            webBrowser.Document.GetElementById("email-input").SetAttribute("value", login);
            webBrowser.Document.GetElementById("pwd-input").SetAttribute("value", pass);

            foreach (HtmlElement el in webBrowser.Document.GetElementsByTagName("button"))
            {
                if (el.GetAttribute("type").Equals("submit"))
                {
                    el.InvokeMember("click");
                    break;
                }
            }
            waitMht(1);

            webBrowsersDic.Add(userIndex, webBrowser);
            Thread.Sleep(10);
        }

        public static void selectedAcc(int index)
        {
            WebBrowser wb = webBrowsersDic[index];
            MessageBox.Show(wb.Handle.ToString());
        }

        public static void goTo(int index)
        {
            WebBrowser wb = webBrowsersDic[index];
            
            string response = wb.DocumentText;
            StreamWriter sw = new StreamWriter("D:\\1\\1.txt", true, System.Text.Encoding.UTF8);
            sw.WriteLine(response);
            sw.Close();

            MessageBox.Show(wb.Handle +" "+ wb.Url.ToString());
        }

        public static void showInfo()
        {
            //form1.BeginInvoke((Action)delegate
            //{
            //    //totalMessage_lbl.Text = (i + 1).ToString();
            //});
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
