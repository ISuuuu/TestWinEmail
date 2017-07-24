using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace sendmail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //http://blog.csdn.net/xianshuang/article/details/3734431
            //llllllllllllllllllllllllllllllllll
            //Test Push on vs2013
            //Test Push on vs2013..
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userid = user_txt.Text.ToString();  //用户名
            string mm = mm_txt.Text.ToString();  //密码
            string yjaddress = yj_txt.Text;
            string[] fasong = yjaddress.Split('@');  //得到邮件地址@前后两部分  zjl@163.com
            string[] fs = fasong[1].Split('.');    //得到163 与com

            string yjshou=yjshou_txt.Text.ToString();   //收件人邮箱

            string zt=zt_txt.Text.ToString();  //邮件主题 
            string content=content_txt.Text.ToString();   //邮件正文 



            //发送
            SmtpClient client = new SmtpClient("smtp." + fs[0].ToString().Trim() + ".com");  //设置右键协议  eg:smtp.163.com
            client.UseDefaultCredentials = false;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;  //通过网络发送到Smtp服务器
            client.Credentials = new NetworkCredential(fasong[0].ToString(), mm);
            MailMessage mmsg = new MailMessage(new MailAddress(yjaddress), new MailAddress(yjshou));  //发件人收件人邮箱地址


            mmsg.Subject = zt;
            mmsg.SubjectEncoding = Encoding.UTF8;
            mmsg.Body = content;
            mmsg.BodyEncoding = Encoding.UTF8;
            mmsg.IsBodyHtml = true;
            mmsg.Priority = MailPriority.High;  //优先级

            try
            {
                client.Send(mmsg);
                MessageBox.Show("发送成功！", "tips");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
