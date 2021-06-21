using MailKit.Net.Imap;
using MailKit.Security;
using MailKit;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Net;
using System;
using System.Collections.Generic;

namespace lab5.Bai5
{
    public partial class MailBox : Form
    {
        private string username = "";
        private string password = "";
        string IP = "127.0.0.1";
        int Port = 143; // Default
        public MailBox(string u, string p)
        {
            InitializeComponent();
            this.username = u;
            this.password = p;
            GetMessageFromAccount();
        }

        List<string> ListMessage = new List<string>();

        private void GetMessageFromAccount()
        {
            listView1.Items.Clear();
            ListMessage.Clear();
            using (var client = new ImapClient())
            {
                client.CheckCertificateRevocation = false;
                client.Connect(IP, Port, SecureSocketOptions.None);
                client.Authenticate(this.username, this.password);
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                for (int i = 0; i < inbox.Count; i++)
                {
                    var message = inbox.GetMessage(i);
                    ListViewItem name = new ListViewItem(message.Subject);
                    ListViewItem.ListViewSubItem from = new
                    ListViewItem.ListViewSubItem(name, message.From.ToString());
                    name.SubItems.Add(from);
                    ListViewItem.ListViewSubItem date = new
                    ListViewItem.ListViewSubItem(name, message.Date.Date.ToString());
                    name.SubItems.Add(date);
                    listView1.Items.Add(name);
                    ListMessage.Add(message.Body.ToString());
                }
            }
        }

        private void RefreshBtn_Click(object sender, System.EventArgs e)
        {
            GetMessageFromAccount();
        }

        private void SendBtn_Click(object sender, System.EventArgs e)
        {
            string from = mailfromtxt.Text, to = mailtotxt.Text, subject = Subjecttxt.Text, content = contenttxt.Text, pass = Passtxt.Text;

            using (SmtpClient smtpClient = new SmtpClient(IP))
            {
                var basicCredential = new NetworkCredential(from, pass);
                using (MailMessage message = new MailMessage())
                {
                    MailAddress fromAddress = new MailAddress(from);
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = basicCredential;
                    message.From = fromAddress;
                    message.Subject = subject.ToString().Trim();
                    // Set IsBodyHtml to true means you can send HTML email.
                    message.IsBodyHtml = true;
                    message.Body = content.ToString();
                    message.To.Add(to);
                    try
                    {
                        smtpClient.Send(message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }


        }

        private void listView1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                int index = listView1.SelectedItems[0].Index;
                //string pattern = "\".*?\"(.*?)";
                //if (Regex.IsMatch(current, pattern))
                //{
                //    string text = Regex.Matches(current, pattern)[0].Groups[1].Value;
                //    msgcontent.Text = text;
                //}

                msgcontent.Text = ListMessage[index];
            }
        }

    }
}
