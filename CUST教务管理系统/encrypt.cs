using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CUST教务管理系统
{
    class encrypt
    {
        static public string Base64Decode(string str)  //base64->string
        {
            try
            {
                return System.Text.ASCIIEncoding.Default.GetString(Convert.FromBase64String(str));
            }
            catch
            {
                return "";
            }
        }
        static public string Base64Encode(string str)  //string->base64
        {
            try
            {
                System.Text.Encoding encode = System.Text.Encoding.ASCII;
                byte[] bytedata = encode.GetBytes(str);
                return Convert.ToBase64String(bytedata, 0, bytedata.Length);
            }
            catch
            {
                return "";
            }
        }
        static public string wvc(string str)    //前后2位互换简单加密
        {
            char[] result = new char[str.Length];
            if (str.Length % 2 == 0)
                for (int i = 0; i <= str.Length - 2; i = i + 2)
                {
                    result[i] = str[i + 1];
                    result[i + 1] = str[i];
                }
            string temp = new string(result);
            return temp;
        }
    }
}
