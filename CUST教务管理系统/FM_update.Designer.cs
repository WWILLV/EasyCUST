namespace CUST教务管理系统
{
    partial class FM_update
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_checkUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 204);
            this.label1.TabIndex = 0;
            this.label1.Text = "最近更新(V 2.1.2)：\r\n\r\n1、加密保存的用户名和密码\r\n\r\n2、增加网络检测\r\n-------------------------------\r\n之前更" +
    "新：\r\n\r\nV 2.1.1\r\n\r\n1、本地保存用户名密码快速登录\r\n\r\n2、增加南区实验室宽带连接\r\n\r\n3、修改UI，更美观\r\n\r\n4、修复了一些已知的Bug" +
    "";
            // 
            // btn_checkUpdate
            // 
            this.btn_checkUpdate.Location = new System.Drawing.Point(197, 226);
            this.btn_checkUpdate.Name = "btn_checkUpdate";
            this.btn_checkUpdate.Size = new System.Drawing.Size(75, 23);
            this.btn_checkUpdate.TabIndex = 1;
            this.btn_checkUpdate.Text = "检查更新";
            this.btn_checkUpdate.UseVisualStyleBackColor = true;
            this.btn_checkUpdate.Click += new System.EventHandler(this.btn_checkUpdate_Click);
            // 
            // FM_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_checkUpdate);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FM_update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "更新";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_checkUpdate;
    }
}