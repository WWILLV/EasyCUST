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

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }
    }
}
