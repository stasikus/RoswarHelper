using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoswarHelper
{
    class MyProxy
    {
        public enum ProxyTypes
        {
            HTTP,
            Socks4,
            Socks5,
        }
        public ProxyTypes myProxyType;

        //public string type = null;

        public const int StartErrors = 2;
        public const int MaxErrors = 5;

        public int ErrorsCount { get; set; }
        public string adress_port;

        public MyProxy(string addressAndPort, ProxyTypes Ptype)
        {
            adress_port = addressAndPort;
            ErrorsCount = StartErrors;
            myProxyType = Ptype;
        }
    }
}
