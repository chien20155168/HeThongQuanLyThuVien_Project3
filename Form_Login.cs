using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib_Manage
{
    public partial class Form_Login : Form
    {
        static public String MNV = null;
        static public TextBox tbPass;

        public Form_Login()
        {
            InitializeComponent();
            tbPass = textBox2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String exeString = "SELECT MNV,Pass FROM Staff WHERE MNV=N'" + textBox1.Text + "' AND Pass= N'" + textBox2.Text + "'";
            DataTable dt = new Class_CRUDdb().readData(exeString);
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                MNV = dr["MNV"].ToString();
                new Home(this).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username hoặc Password Không đúng!");
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new Form_themStaff().ShowDialog();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
        }
    }
}
