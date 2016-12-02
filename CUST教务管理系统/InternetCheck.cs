using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace CUST教务管理系统
{
    class InternetCheck
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(int Description, int ReservedValue);
        
        /// <summary>
        /// 用于检查网络是否可以连接互联网,true表示连接成功,false表示连接失败 
        /// </summary>
        /// <returns></returns>
        public static bool IsConnectInternet()
        {
            int Description = 0;
            return InternetGetConnectedState(Description, 0);
        }
    }
}
