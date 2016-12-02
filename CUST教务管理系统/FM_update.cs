using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CUST教务管理系统
{
    public partial class FM_update : Form
    {
        public FM_update()
        {
            InitializeComponent();
        }

        private void btn_checkUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("开源后会放出更新");
        }
    }
}
