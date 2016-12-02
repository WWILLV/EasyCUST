using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Net.Mail;

namespace CUST教务管理系统

{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FM1());
        }
    }


    //public static class messagesendStr
    //{
    //    public static string messagesend = "";
    //}
    //public partial class testSendMail : System.Web.UI.Page
    //{
    //    public bool site;
    //    public testSendMail()
    //    {
    //        site = true;
    //    }
    //    public void Page_Load()
    //    {
    //        string strFrom = "kamina9@163.com";
    //        string strTo = "767436053@163.com";
    //        string strSubject = "CUST教务管理系统";
    //        string strBody = messagesendStr.messagesend;
    //        System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage(strFrom, strTo, strSubject, strBody);
    //        message.BodyEncoding = System.Text.Encoding.UTF8;
    //        message.IsBodyHtml = true;
    //        SendSMTPEMail("smtp.163.com", "kamina9@163.com", "631123", message);

    //    }
    //    public void SendSMTPEMail(string strSmtpServer, string strFrom, string strFromPass, MailMessage message)
    //    {
    //        try
    //        {
    //            SmtpClient client = new SmtpClient(strSmtpServer);
    //            client.UseDefaultCredentials = true;
    //            client.Credentials = new System.Net.NetworkCredential(strFrom, strFromPass);
    //            client.DeliveryMethod = SmtpDeliveryMethod.Network;

    //            client.Send(message);
    //        }
    //        catch (Exception ex)
    //        {
    //            site = false;
    //            MessageBox.Show("网络连接异常！");
    //            //throw new Exception(ex.Message);
    //        }
    //}
//}
}
