using Newtonsoft.Json.Linq;
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
        public static HttpRequest Auth(string login, string pass, string proxy)
        {
            var request = new HttpRequest();
            //request.Proxy = HttpProxyClient.Parse(proxy);
            request.UserAgent = HttpHelper.ChromeUserAgent();
            request.Cookies = new CookieDictionary();
            string post = request.Post("http://www.roswar.ru/login/", "action=login&email=" + System.Web.HttpUtility.UrlEncode(login) + "&password=" + System.Web.HttpUtility.UrlEncode(pass, Encoding.GetEncoding(1251)) + "&remember=on", "application/x-www-form-urlencoded").ToString();

            StreamWriter sw = new StreamWriter("D:\\1\\1_" + login + ".txt", true, System.Text.Encoding.GetEncoding(1251));
            sw.Write(post);
            sw.Close();
            
            return request;
        }
        public static void restoreHP(HttpRequest request)
        {
            request.AddField("X-Requested-With", "XMLHttpRequest");
            string post = request.Post("http://www.roswar.ru/player/restorehp/", "action=restorehp", "application/x-www-form-urlencoded").ToString();
            
            //StreamWriter sw = new StreamWriter("D:\\1\\1\\2.txt", true, System.Text.Encoding.GetEncoding(1251));
            //sw.Write(post);
            //sw.Close();
        }

        public static int spendGold(HttpRequest request, int playType)
        {
            int goldLeft = 0;
            request.AddHeader("X-Requested-With", "XMLHttpRequest");
            request.Post("http://www.roswar.ru/camp/gypsy/", "action=gypsyStart&gametype="+playType+"", "application/x-www-form-urlencoded");
            
            System.Threading.Thread.Sleep(500);

            request.AddHeader("X-Requested-With", "XMLHttpRequest");
            string post = request.Post("http://www.roswar.ru/camp/gypsy/", "action=gypsyAuto", "application/x-www-form-urlencoded").ToString();

            JObject goldLeftjObject = JObject.Parse(post);

            //StreamWriter sw = new StreamWriter("D:\\1\\1\\gol.txt", true, System.Text.Encoding.GetEncoding(1251));
            //sw.Write(goldLeftjObject);
            //sw.Close();

            goldLeft = Convert.ToInt32(goldLeftjObject["gold"]);

            System.Threading.Thread.Sleep(1000);

            return goldLeft;
        }

        public static string goToPatrol(HttpRequest request, int time)
        {
            string status = "";
            request.AddHeader("X-Requested-With", "XMLHttpRequest");
            string post = request.Post("http://www.roswar.ru/alley/", "action=patrol&region=2&time=" + time + "&__ajax=1&return_url=/alley/", "application/x-www-form-urlencoded").ToString();

            StreamWriter sw = new StreamWriter("D:\\1\\patrol.txt", true, System.Text.Encoding.GetEncoding(1251));
            sw.Write(post);
            sw.Close();

            JObject returnStatusjObject = JObject.Parse(post);

            status = returnStatusjObject["return_url"].ToString();

            return status;
        }
        
    }
}