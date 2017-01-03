using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUST教务管理系统

{
    public partial class FM1 : Form
    {
        private string loginurl;
        private int clickbrowser;
        private bool isbrowser;
        Log LogWriter = new Log("log.txt");
        /// <summary>
        /// 浏览器模式打开的url
        /// </summary>
        /// <param name="url">要再浏览器中打开URL</param>
        private void browesermode(string url)
        {
            if (isbrowser)
                System.Diagnostics.Process.Start(url);
        }
        /// <summary>
        /// Just for fun，教务管理的错误界面
        /// </summary>
        /// <param name="str">想出现的错误信息</param>
        /// <returns></returns>
        private string jwglError(string str)
        {
            string url = "http://jwgl.cust.edu.cn/teachweb/Error.aspx?errorInfo=【这里】&noReturn=true";
            return url.Replace("【这里】", str); ;
        }
        public FM1()
        {
            InitializeComponent();
            clickbrowser = 1;
            isbrowser = false;
            webBrowser1.Navigate("http://jwgl.cust.edu.cn/teachwebsl/login.aspx");
            //抢课及评估未完成~
            btn_choseclass.Visible = false;
            btn_teachergrade.Visible = false;
        }
        #region 按钮事件

        private void btn_login_Click(object sender, EventArgs e)    //登录
        {
            loginurl = "http://jwgl.cust.edu.cn/teachwebsl/login.aspx?__VIEWSTATE=%2FwEPDwUJMTQyNDg3OTM5ZGQ%3D&__EVENTVALIDATION=%2FwEWBAK4vfWFDAKl1bKzCQK1qbSWCwKM54rGBg%3D%3D&txtUserName=" + textBox_usernum.Text + "&txtPassWord=" + textBox_pwd.Text + "&Button1=%E7%99%BB%E5%BD%95";
            webBrowser1.Navigate(loginurl);
            browesermode(loginurl);
            string log = textBox_usernum.Text + "登录教务管理系统";
            LogWriter.loginWrite(log);
        }

        private void btn_class_Click(object sender, EventArgs e)    //选课
        {
            string url = "http://jwgl.cust.edu.cn/teachweb/xkxt/CSSelectLesson.aspx";
            webBrowser1.Navigate(url);
            browesermode(url);
        }

        private void btn_grade_Click(object sender, EventArgs e)    //成绩查询
        {
            string url = "http://jwgl.cust.edu.cn/teachweb/cjcx/StudentGrade.aspx";
            webBrowser1.Navigate(url);
            browesermode(url);
        }

        private void btn_lab_Click(object sender, EventArgs e)      //实验查询
        {
            string url = "http://jwgl.cust.edu.cn/teachweb/syyy/EBCousesQuery.aspx";
            webBrowser1.Navigate(url);
            browesermode(url);
        }

        private void btn_result_Click(object sender, EventArgs e)   //选课结果
        {
            string url = "http://jwgl.cust.edu.cn/teachweb/xkxt/SelectInfoResult.aspx";
            webBrowser1.Navigate(url);
            browesermode(url);
        }

        private void btn_backindex_Click(object sender, EventArgs e)    //返回主界面
        {
            string url = "http://jwgl.cust.edu.cn/teachweb/index1.aspx";
            webBrowser1.Navigate(url);
            browesermode(url);
        }

        private void btn_choseclass_Click(object sender, EventArgs e)   //一键抢课
        {
            string url = "http://jwgl.cust.edu.cn/teachweb/xkxt/CSSelectLesson.aspx";
            btn_class_Click(btn_class, new EventArgs());
            MessageBox.Show("开发中");
            //string choosenum = "33";//课程从上向下的顺序
            //string post = "__EVENTTARGET=" + choosenum + "&__EVENTARGUMENT=&__VIEWSTATE=dDw4NzEyMDk0MzQ7dDw7bDxpPDE%2BOz47bDx0PDtsPGk8Mj47aTw4Pjs%2BO2w8dDxwPHA8bDxUZXh0Oz47bDwyMDE2LTIwMTflrablubTnrKzkuIDlrabmnJ87Pj47Pjs7Pjt0PDtsPGk8MD47PjtsPHQ8O2w8aTwwPjtpPDE%2BO2k8Mj47PjtsPHQ8cDxwPGw8SG9yaXpvbnRhbEFsaWduO18hU0I7PjtsPFN5c3RlbS5XZWIuVUkuV2ViQ29udHJvbHMuSG9yaXpvbnRhbEFsaWduLCBTeXN0ZW0uV2ViLCBWZXJzaW9uPTEuMC41MDAwLjAsIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49YjAzZjVmN2YxMWQ1MGEzYTxSaWdodD47aTw2NTUzNj47Pj47Pjs7Pjt0PHA8cDxsPEhvcml6b250YWxBbGlnbjtfIVNCOz47bDw1MDxDZW50ZXI%2BO2k8NjU1MzY%2BOz4%2BOz47Oz47dDxwPHA8bDxIb3Jpem9udGFsQWxpZ247XyFTQjs%2BO2w8NTA8TGVmdD47aTw2NTUzNj47Pj47Pjs7Pjs%2BPjs%2BPjs%2BPjs%2BPjtsPDE7MjszOzQ7NTs2OzEwOzExOzIxOzIyOzIzOzI0OzI1OzI2OzI3OzI4OzI5OzMwOzMxOzMyOzMzOzM0OzM1OzM2OzM3OzM4OzM5OzQwOzQxOzQyOzQzOzQ0OzQ1OzQ2OzQ3OzQ4OzQ5OzUwOzUxOzUyOzUzOz4%2BpaDSqdIC1XV%2BOOHEltfrv2fTSZo%3D&1=on&2=on&3=on&4=on&5=on&10=on&" + choosenum + "=on&scrollValue=756";
            //byte[] postdata = System.Text.Encoding.UTF8.GetBytes(post);
            //webBrowser1.Navigate(url, "", postdata, "");

            //接口如下：
            //选课：
            //__EVENTTARGET = 34 & __EVENTARGUMENT = &__VIEWSTATE = dDw4NzEyMDk0MzQ7dDw7bDxpPDE % 2BOz47bDx0PDtsPGk8Mj47aTw4Pjs % 2BO2w8dDxwPHA8bDxUZXh0Oz47bDwyMDE2LTIwMTflrablubTnrKzkuIDlrabmnJ87Pj47Pjs7Pjt0PDtsPGk8MD47PjtsPHQ8O2w8aTwwPjtpPDE % 2BO2k8Mj47PjtsPHQ8cDxwPGw8SG9yaXpvbnRhbEFsaWduO18hU0I7PjtsPFN5c3RlbS5XZWIuVUkuV2ViQ29udHJvbHMuSG9yaXpvbnRhbEFsaWduLCBTeXN0ZW0uV2ViLCBWZXJzaW9uPTEuMC41MDAwLjAsIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49YjAzZjVmN2YxMWQ1MGEzYTxSaWdodD47aTw2NTUzNj47Pj47Pjs7Pjt0PHA8cDxsPEhvcml6b250YWxBbGlnbjtfIVNCOz47bDw1MDxDZW50ZXI % 2BO2k8NjU1MzY % 2BOz4 % 2BOz47Oz47dDxwPHA8bDxIb3Jpem9udGFsQWxpZ247XyFTQjs % 2BO2w8NTA8TGVmdD47aTw2NTUzNj47Pj47Pjs7Pjs % 2BPjs % 2BPjs % 2BPjs % 2BPjtsPDE7MjszOzQ7NTs2OzEwOzExOzIxOzIyOzIzOzI0OzI1OzI2OzI3OzI4OzI5OzMwOzMxOzMyOzMzOzM0OzM1OzM2OzM3OzM4OzM5OzQwOzQxOzQyOzQzOzQ0OzQ1OzQ2OzQ3OzQ4OzQ5OzUwOzUxOzUyOzUzOz4 % 2BpaDSqdIC1XV % 2BOOHEltfrv2fTSZo % 3D & 1 = on & 2 = on & 3 = on & 4 = on & 5 = on & 10 = on & 34 = on & scrollValue = 827
            //__EVENTTARGET = 33 & __EVENTARGUMENT = &__VIEWSTATE = dDw4NzEyMDk0MzQ7dDw7bDxpPDE % 2BOz47bDx0PDtsPGk8Mj47aTw4Pjs % 2BO2w8dDxwPHA8bDxUZXh0Oz47bDwyMDE2LTIwMTflrablubTnrKzkuIDlrabmnJ87Pj47Pjs7Pjt0PDtsPGk8MD47PjtsPHQ8O2w8aTwwPjtpPDE % 2BO2k8Mj47PjtsPHQ8cDxwPGw8SG9yaXpvbnRhbEFsaWduO18hU0I7PjtsPFN5c3RlbS5XZWIuVUkuV2ViQ29udHJvbHMuSG9yaXpvbnRhbEFsaWduLCBTeXN0ZW0uV2ViLCBWZXJzaW9uPTEuMC41MDAwLjAsIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49YjAzZjVmN2YxMWQ1MGEzYTxSaWdodD47aTw2NTUzNj47Pj47Pjs7Pjt0PHA8cDxsPEhvcml6b250YWxBbGlnbjtfIVNCOz47bDw1MDxDZW50ZXI % 2BO2k8NjU1MzY % 2BOz4 % 2BOz47Oz47dDxwPHA8bDxIb3Jpem9udGFsQWxpZ247XyFTQjs % 2BO2w8NTA8TGVmdD47aTw2NTUzNj47Pj47Pjs7Pjs % 2BPjs % 2BPjs % 2BPjs % 2BPjtsPDE7MjszOzQ7NTs2OzEwOzExOzIxOzIyOzIzOzI0OzI1OzI2OzI3OzI4OzI5OzMwOzMxOzMyOzMzOzM0OzM1OzM2OzM3OzM4OzM5OzQwOzQxOzQyOzQzOzQ0OzQ1OzQ2OzQ3OzQ4OzQ5OzUwOzUxOzUyOzUzOz4 % 2BpaDSqdIC1XV % 2BOOHEltfrv2fTSZo % 3D & 1 = on & 2 = on & 3 = on & 4 = on & 5 = on & 10 = on & 33 = on & scrollValue = 756
            //取消：
            //__EVENTTARGET = 33 & __EVENTARGUMENT = &__VIEWSTATE = dDw4NzEyMDk0MzQ7dDw7bDxpPDE % 2BOz47bDx0PDtsPGk8Mj47aTw4Pjs % 2BO2w8dDxwPHA8bDxUZXh0Oz47bDwyMDE2LTIwMTflrablubTnrKzkuIDlrabmnJ87Pj47Pjs7Pjt0PDtsPGk8MD47PjtsPHQ8O2w8aTwwPjtpPDE % 2BO2k8Mj47PjtsPHQ8cDxwPGw8SG9yaXpvbnRhbEFsaWduO18hU0I7PjtsPFN5c3RlbS5XZWIuVUkuV2ViQ29udHJvbHMuSG9yaXpvbnRhbEFsaWduLCBTeXN0ZW0uV2ViLCBWZXJzaW9uPTEuMC41MDAwLjAsIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49YjAzZjVmN2YxMWQ1MGEzYTxSaWdodD47aTw2NTUzNj47Pj47Pjs7Pjt0PHA8cDxsPEhvcml6b250YWxBbGlnbjtfIVNCOz47bDw1MDxDZW50ZXI % 2BO2k8NjU1MzY % 2BOz4 % 2BOz47Oz47dDxwPHA8bDxIb3Jpem9udGFsQWxpZ247XyFTQjs % 2BO2w8NTA8TGVmdD47aTw2NTUzNj47Pj47Pjs7Pjs % 2BPjs % 2BPjs % 2BPjs % 2BPjtsPDE7MjszOzQ7NTs2OzEwOzExOzIxOzIyOzIzOzI0OzI1OzI2OzI3OzI4OzI5OzMwOzMxOzMyOzMzOzM0OzM1OzM2OzM3OzM4OzM5OzQwOzQxOzQyOzQzOzQ0OzQ1OzQ2OzQ3OzQ4OzQ5OzUwOzUxOzUyOzUzOz4 % 2BpaDSqdIC1XV % 2BOOHEltfrv2fTSZo % 3D & 1 = on & 2 = on & 3 = on & 4 = on & 5 = on & 10 = on & scrollValue = 439
        }

        private void btn_teachergrade_Click(object sender, EventArgs e) //一键评估
        {
            MessageBox.Show("评课默认全评优！", "作者比较懒");
            webBrowser1.Navigate("http://jwgl.cust.edu.cn/teachweb/jspg/CourseEvaluate.aspx");
            MessageBox.Show("开发中");
        }

        private void btn_support_Click(object sender, EventArgs e)  //赞助
        {
            FM_support send = new FM_support();
            send.Show();
        }

        private void btn_course_Click(object sender, EventArgs e)   //课表查询
        {
            string url = "http://jwgl.cust.edu.cn/teachweb/kbcx/Report/wfmRptPersonalCourses.aspx?role=student";
            webBrowser1.Navigate(url);
            browesermode(url);
        }

        private void btn_webpay_Click(object sender, EventArgs e)   //网费充值（主要是获取cookies）
        {
            MessageBox.Show("等浏览器窗口变白后再点一次该按钮！");
            string loginurl = "http://my.cust.edu.cn/userPasswordValidate.portal?Login.Token1="
                + textBox_usernum.Text + "&Login.Token2=" + textBox_pwd.Text;
            //+"&goto=http%3A%2F%2Fmy.cust.edu.cn%2FloginSuccess.portal"&gotoOnFail=http%3A%2F%2Fmy.cust.edu.cn%2FloginFailure.portal";
            webBrowser1.Navigate(loginurl);
            btn_webpay.Visible = true;
            browesermode(loginurl);
        }

        private void btn_webpay_Click_1(object sender, EventArgs e) //再点一次打开充值界面
        {
            btn_webpay.Visible = false;
            webBrowser1.Navigate("http://my.cust.edu.cn/index.portal");
            string tourl = "http://ecard.cust.edu.cn/cclgportalHome.action";
            webBrowser1.Navigate(tourl);
            browesermode(tourl);
            LogWriter.write(textBox_usernum.Text + "充值网费");
        }

        private void btn_notice_Click(object sender, EventArgs e)   //说明
        {
            FM_noticecs send = new FM_noticecs();
            send.Show();
        }

        private void isBrowser_Click(object sender, EventArgs e)    //浏览器模式
        {
            clickbrowser++;
            if (clickbrowser % 2 != 0)
            {
                isBrowser.Checked = false;
                isbrowser = false;
                TopMost = false;
                webBrowser1.Visible = true;
                this.Size = new Size(868, 538);
                group_Function.Dock = DockStyle.Right;
                this.Opacity = 1;
                this.MaximizeBox = true;
            }
            else
            {
                isBrowser.Checked = true;
                isbrowser = true;
                TopMost = true;
                MessageBox.Show("浏览器模式已开启，窗口将置顶，不需要时最小化即可，不建议退出程序", "浏览器模式开启");
                this.WindowState = FormWindowState.Normal;
                webBrowser1.Visible = false;
                this.Size = new Size(300, 538);
                group_Function.Dock = DockStyle.Fill;
                this.Location = new Point(
                    (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                    (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
                this.Opacity = 0.8;
                this.MaximizeBox = false;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e) //退出
        {
            Application.Exit();
        }

        private void btn_feedback_Click(object sender, EventArgs e) //反馈
        {
            FM_feedback child = new FM_feedback();
            child.Owner = this;
            child.Show();
        }

        private void btn_checkupdate_Click(object sender, EventArgs e)  //检查更新
        {
            //string updateurl = "https://about.me/willv";
            //System.Diagnostics.Process.Start(updateurl);
            FM_update child = new FM_update();
            child.Owner = this;
            child.Show();
        }

        private void btn_wtj_Click(object sender, EventArgs e)  //未提交成绩计算器
        {
            FM_wtj child = new FM_wtj();
            child.Owner = this;
            child.Show();
        }

        private void btn_rasdial_Click(object sender, EventArgs e)  //实验室上网，调用ned\conn.bat
        {
            if (!InternetCheck.IsConnectInternet())
            {
                MessageBox.Show("根本连局域网都没连上，检查网线吧！", "低头看看网线",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult a = MessageBox.Show("1、南区实验室拨号上网，不用改IP\n" +
                "2、不是实验室别用这个\n" +
                "3、连接成功后不要重复连接，否则宽带连接可能会崩溃", "注意", MessageBoxButtons.OKCancel);
            string path = @"ned\\conn.bat";
            if ((int)a == 1)
            {
                try
                {
                    System.Diagnostics.Process.Start(path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nned文件夹下缺少文件conn.bat");
                }
            }
        }

        private void btn_auto_Click(object sender, EventArgs e) //快速登录 
        {
            usr user = new usr();
            user = info.JsonOut(@"usr\\usr.json");
            textBox_usernum.Text = encrypt.Base64Decode(encrypt.wvc(user.name));
            textBox_pwd.Text = encrypt.Base64Decode(encrypt.wvc(user.pass));
            btn_login_Click(btn_login, new EventArgs());
        }

        private void btn_quickLog_Click(object sender, EventArgs e) //保存登录
        {
            MessageBox.Show("将保存现在学号密码栏中的登录信息以便下次登录");
            usr user = new usr();
            user.name = encrypt.wvc(encrypt.Base64Encode(textBox_usernum.Text));
            user.pass = encrypt.wvc(encrypt.Base64Encode(textBox_pwd.Text));
            info.JsonIn(user, @"usr\\usr.json");
            LogWriter.write(textBox_usernum.Text + "保存登录信息");
        }

        private void btn_fangan_Click(object sender, EventArgs e)   //培养方案
        {
            string url = "http://jwc.cust.edu.cn/Resource.asp?BigClassID=109&SmallClassID=524";
            webBrowser1.Navigate(url);
        }

        private void linkLabel_open_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //开源链接
        {
            string url = "https://github.com/TheGreatFireWall/EasyCUST";
            System.Diagnostics.Process.Start(url);
        }

        private void btn_willv_Click(object sender, EventArgs e)    //作者主页
        {
            string url = "http://www.willv.cn";
            System.Diagnostics.Process.Start(url);
        }

        #endregion

    }
}
