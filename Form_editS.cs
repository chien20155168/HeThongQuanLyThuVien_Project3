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
    public partial class Form_editS : Form
    {
        String MS;
        public Form_editS(String ms)
        {
            InitializeComponent();
            MS = ms;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Tongsach = Int32.Parse(textBox5.Text);
            if (true)//Kiemtra input
            {
                String temp = "UPDATE Books SET Ten=N'" + textBox2.Text + "',TacGia=N'" + textBox3.Text + "',NXB=N'"
                + textBox4.Text + "',TongSach=" + Tongsach + ",DaMuon=" + Int32.Parse(textBox6.Text) +  " WHERE MS = N'" + MS + "'";
                if (new Class_CRUDdb().exeData(temp))
                {
                    MessageBox.Show("Sửa tt sách ThÀNH CÔNG.");
                }
                else
                {
                    MessageBox.Show("Sửa tt sách THẤT BẠI.");
                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại các trường dữ liệu.");
            }
        }

        private void Form_editS_Load(object sender, EventArgs e)
        {
            DataTable dt = new Class_CRUDdb().readData("SELECT * FROM Books WHERE MS='" + MS + "'");
            DataRow dr = dt.Rows[0];
            textBox1.Text = dr["MS"].ToString();
            textBox2.Text = dr["Ten"].ToString();
            textBox3.Text = dr["TacGia"].ToString();
            textBox4.Text = dr["NXB"].ToString();
            textBox5.Text = dr["TongSach"].ToString();
            textBox6.Text = dr["DaMuon"].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
