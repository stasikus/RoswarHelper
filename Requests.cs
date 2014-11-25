using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet.Collections;
using xNet.Net;

namespace RoswarHelper
{
    class Requests
    {
        public static HttpRequest Auth(string login, string pass, TextBox textBox1)
        {
            var request = new HttpRequest();
            request.UserAgent = HttpHelper.ChromeUserAgent();
            request.Cookies = new CookieDictionary();
            string get = request.Get("http://www.roswar.ru/login/").ToString();
            string post = request.Post("http://www.roswar.ru/login/", "action=login&email=" + System.Web.HttpUtility.UrlEncode(login) + "&password=" + System.Web.HttpUtility.UrlEncode(pass, Encoding.GetEncoding(1251)) + "&remember=on", "application/x-www-form-urlencoded").ToString();
            StreamWriter sw = new StreamWriter("D:\\1\\1.txt", true, System.Text.Encoding.GetEncoding(1251));
            sw.Write(post);
            sw.Close();

            return request;
        }

        public static void restoreHP(HttpRequest request)
        {
            request.AddField("X-Requested-With", "XMLHttpRequest");
            string post = request.Post("http://www.roswar.ru/player/restorehp/", "action=restorehp", "application/x-www-form-urlencoded").ToString();

            StreamWriter sw = new StreamWriter("D:\\1\\2.txt",true,System.Text.Encoding.GetEncoding(1251));
            sw.Write(post);
            sw.Close();
        }

        public static int spendGold(HttpRequest request, int playType)
        {
            int goldLefet = 0;
            request.AddHeader("X-Requested-With", "XMLHttpRequest");

            var urlParams = new RequestParams();
            urlParams["action"] = "gypsyStart";
            urlParams["gametype"] = playType;

            string post = request.Post("http://www.roswar.ru/camp/gypsy/", urlParams.ToString(), "application/x-www-form-urlencoded").ToString();

            StreamWriter sw = new StreamWriter("D:\\1\\3.txt", true, System.Text.Encoding.GetEncoding(1251));
            sw.Write(post);
            sw.Close();
        
            //string post = request.Post("http://www.roswar.ru/camp/gypsy/", "action=gypsyAuto", "application/x-www-form-urlencoded").ToString();


            return goldLefet;
        }
    }
}
