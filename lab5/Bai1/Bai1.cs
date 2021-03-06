using MailKit.Net.Imap;
using MailKit.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            using (SmtpClient smtpClient = new SmtpClient("127.0.0.1"))
            {
                string mailfrom = textBox1.Text.ToString().Trim();
                string mailto = textBox2.Text.ToString().Trim();
                string password = textBox3.Text.ToString().Trim();
                if (mailfrom == "" || mailto == "")
                {
                    MessageBox.Show("from/to/password not allowed empty");
                    return;
                }
                using(var client=new ImapClient())
                {
                    client.CheckCertificateRevocation = false;
                    client.Connect("127.0.0.1", 143, SecureSocketOptions.None);
                    try
                    {
                        client.Authenticate(mailfrom, password);
                        
                    }
                    catch
                    {
                        MessageBox.Show("Sai mật khẩu");
                        return;
                    }
                }
                   
                
                var basicCredential = new NetworkCredential(mailfrom, password);
                using (MailMessage message = new MailMessage())
                {
                    try
                    {
                        MailAddress fromAddress = new MailAddress(mailfrom);
                        smtpClient.UseDefaultCredentials = false;
                        smtpClient.Credentials = basicCredential;
                        message.From = fromAddress;
                        message.Subject = textBox4.Text.ToString().Trim();

                        message.IsBodyHtml = true;
                        message.Body = richTextBox1.Text.ToString();
                        message.To.Add(mailto);
                    }
                    catch
                    {
                        MessageBox.Show("invalid email");
                    }
                   
                    try
                    {
                        smtpClient.Send(message);
                        MessageBox.Show("message sent");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Message cannot be sent");
                    }
                }
            }

        }
    }
}
