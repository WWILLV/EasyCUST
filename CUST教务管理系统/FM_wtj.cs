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
    public partial class FM_wtj : Form
    {
        public FM_wtj()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 计算按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label8.Text =
                Convert.ToString(
                (Convert.ToDouble(textBox3.Text) * Convert.ToDouble(textBox4.Text)
                - Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text))
                / Convert.ToDouble(textBox5.Text));
                if (Convert.ToDouble(label8.Text) < 1)
                    label8.Text = "计算小于1（即60分），可能已挂科……";
            }
            catch (System.FormatException)
            {
                MessageBox.Show("输入有误！");
                //throw;
            }
        }

        /// <summary>
        /// 打开系统计算器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }
        
        /// <summary>
        /// 自动计算未提交学分
        /// </summary>
        private void credit()
        {
            if (textBox4.Text != "" && textBox2.Text != "")
            {
                double credit = Convert.ToDouble(textBox4.Text) - Convert.ToDouble(textBox2.Text);
                textBox5.Text = credit.ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            credit();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            credit();
        }
    }
}
