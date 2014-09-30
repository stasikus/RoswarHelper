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
        public static Dictionary<WebBrowser, int> webBrowsersDic = new Dictionary<WebBrowser, int>();

        public static void mainWork(int userIndex, string name, string pass)
        {
            webBrowsersDic.Clear();
            WebBrowser webBrowser = new WebBrowser();
            webBrowsersDic.Add(webBrowser, userIndex);
        }

        public static void selectedAcc(string index)
        {
           // WebBrowser wb = webBrowsersDic.ElementAt(index).Key;
        }


    }
}
