using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoswarHelper
{
    public class Main
    {
        public static Dictionary<int, int> webBrowsersDic = new Dictionary<int, int>();

        public Main()
        {
            for (int i = 0; i < LoadList.userDictionary.Count; i++)
            {
                Thread th = new Thread(() => Main.mainWork(i, LoadList.userDictionary.ElementAt(i).Key, LoadList.userDictionary.ElementAt(i).Value));
                th.IsBackground = true;
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                Thread.Sleep(10);
            }
        }


        public static void mainWork(int userIndex, string name, string pass)
        {
            webBrowsersDic.Clear();
            WebBrowser webBrowser = new WebBrowser();
            webBrowsersDic.Add(webBrowser.Handle.ToInt32(), userIndex);
            webBrowser.Url = new Uri("http://www.roswar.ru");
            var file = webBrowser.DocumentText;
        }


    }
}
