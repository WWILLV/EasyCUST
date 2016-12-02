using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace CUST教务管理系统
{
    public class info
    {
        usr usrin = new usr();  //New一个usr对象，写json用

        /// <summary>
        /// 读json信息
        /// </summary>
        /// <param name="path">json文件的路径</param>
        /// <returns>usr类对象</returns>
        public static usr JsonOut(string path)
        {
            usr readback = new usr();
            try
            {
                StreamReader sr = new StreamReader(path);
                string jsonText = sr.ReadLine();

                //参考 http://blog.csdn.net/ximen250/article/details/9061851
                JObject jo = JObject.Parse(jsonText);
                JToken ageTokenname = jo["name"];
                readback.name = ageTokenname.ToString();
                JToken ageTokenpass = jo["pass"];
                readback.pass = ageTokenpass.ToString();

                sr.Close();
            }
            catch (FileNotFoundException)
            {
                FileStream myFs = new FileStream(path, FileMode.Create);
                byte[] init = System.Text.Encoding.ASCII.GetBytes("{\"name\":\"\",\"pass\":\"\"}");
                myFs.Write(init,0,init.Length);
                MessageBox.Show("登录信息不存在，已新建！");
                myFs.Close();
                return readback;
            }
            return readback;
        }

        /// <summary>
        /// 写json信息
        /// </summary>
        /// <param name="usrin">要写入的usr对象</param>
        /// <param name="path">json的路径</param>
        public static void JsonIn(usr usrin, string path)
        {
            if (usrin.name == "" || usrin.pass == "")
            {
                DialogResult a = MessageBox.Show("未输入用户名或密码\n如果有保存的登录信息将清空！"
                    , "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if ((int)a == 2)
                    return;
            }
            try
            {
                DialogResult b = MessageBox.Show("保存的登录信息将更新，旧登录信息将删除！"
                    , "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if ((int)b == 2)
                    return;
                //参考 http://blog.csdn.net/gf771115/article/details/27114257 序列化
                StreamWriter sw = new StreamWriter(path, false);
                string strSerializeJSON = JsonConvert.SerializeObject(usrin);
                sw.Flush();
                sw.Write(strSerializeJSON);
                sw.Close();
            }
            catch (FileNotFoundException)
            {
                FileStream myFs = new FileStream(path, FileMode.Create);
                byte[] init = System.Text.Encoding.ASCII.GetBytes("{\"name\":\"\",\"pass\":\"\"}");
                myFs.Write(init, 0, init.Length);
                MessageBox.Show("登录信息不存在，已新建！");
                myFs.Close();
            }
}
    }
    /// <summary>
    /// usr类，包含登录名和密码
    /// </summary>
    public class usr
    {
        public string name;
        public string pass;
    }
}
