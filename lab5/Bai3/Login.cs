using System;
using System.Windows.Forms;
using lab5.Bai5;
using MailKit.Net.Imap;
using MailKit.Security;

namespace lab5
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var client = new ImapClient())
            {
                client.CheckCertificateRevocation = false;
                client.Connect("127.0.0.1", 143, SecureSocketOptions.None);
                //Connect Local.
                try
                {
                    client.Authenticate(username.Text, password.Text);
                    //Check Authenticate with username password input
                    // If not Authenticate it will cause exception
                    MailBox mb = new MailBox(username.Text, password.Text);
                    //Use this authentication from input to Mailbox form

                    mb.Disposed += delegate {
                        this.Dispose();
                    };
                    // When mailbox exit main form will exit
                    mb.Show();

                    this.Hide();
                }
                catch
                {
                    MessageBox.Show("Username or password is incorrect !!!");
                    return;
                }


                client.Disconnect(true);// Use true param, LOGOUT will called.
            }
        }
    }
}
