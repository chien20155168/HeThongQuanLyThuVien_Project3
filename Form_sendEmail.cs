using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib_Manage
{
    public partial class Form_sendEmail : Form
    {
        int mov, x, y;
        String attachFilePath;
        Attachment attach=null;
        public Form_sendEmail(String toEmail,String fromMail)
        {
            InitializeComponent();
            int x = Screen.PrimaryScreen.WorkingArea.Right - this.Width;
            int y = Screen.PrimaryScreen.WorkingArea.Bottom - this.Height;
            this.Location = new Point(x, y);
            textBox1.Text = toEmail;
            textBox2.Text = "Demo BTL";
            textBox3.Text = fromMail;

        }

        private void Form_sendEmail_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[1].WorkingArea.Location;  
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;x = e.X;y = e.Y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            attach = null;
            try
            {
                attach = new Attachment(attachFilePath);
            }
            catch { }
            GuiMail(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text,attach);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1) SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                attachFilePath = dialog.FileName;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        } 


        public void GuiMail(string to, string subject, string usr, string pass, string message, Attachment file)
        {
            try
            {
                MailMessage mess = new MailMessage(usr, to, subject, message);
                if (attach != null) mess.Attachments.Add(attach);
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(usr, pass);
                try
                {
                    client.Send(mess);
                }
                catch { }
                MessageBox.Show("Đã gửi xong!");
                //https://myaccount.google.com/u/1/lesssecureapps
            }
            catch { }
        }
    }
}
