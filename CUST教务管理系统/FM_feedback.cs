using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUST教务管理系统
{
    public partial class FM_feedback : Form
    {
        public FM_feedback()
        {
            InitializeComponent();
            textBox1.Visible = false;
            label2.Visible = false;
            textBox2.Visible = false;
            button1.Text = "戳作者QQ";
            label1.Text = "\t反馈功能异常！\r\n\r\n直接联系作者QQ：767436053。\r\n\r\n" +
                "点击\"戳作者QQ\"就可以打开QQ联系作者！\r\n\r\n" +
                "- -Ps.其实就是作者的原来用来发送反馈的邮箱不能用了QAQ\r\n\r\n" +
                "\t求赞助不用的邮箱QAQ";
            textBox1.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (textBox2.Text != ""&&textBox1.Text!="")
            //{
            //    messagesendStr.messagesend = "来自："
            //        + textBox2.Text + "的反馈：" + textBox1.Text
            //        + "     ——CUST教务管理系统V2.0.0";
            //    testSendMail send = new testSendMail();
            //    send.Page_Load();
            //    if (send.site == true)
            //    {
            //        MessageBox.Show("已发送");
            //    }
            //    else
            //        MessageBox.Show("发送失败！");
            //    this.Close();
            //}
            //else
            //    MessageBox.Show("请填写所有内容！");
            //MessageBox.Show("反馈功能异常！\n直接联系作者QQ：767436053");
            System.Diagnostics.Process.Start("http://sighttp.qq.com/msgrd?v=3&uin=767436053&site=&menu=yes");
        }
    }
}
