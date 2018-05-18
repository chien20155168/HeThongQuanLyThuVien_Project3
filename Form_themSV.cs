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
    public partial class Form_themSV : Form
    {
        public Form_themSV()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (true)//Kiemtra input
            {
                String str = "INSERT INTO Student (MSV,Ten,Gioitinh,Ngaysinh,Diachi,Email,Sdt) VALUES" +
                " (N'" + textBox1.Text + "',N'" + textBox2.Text + "',N'" + comboBox1.Text + "',N'" + 
                dateTimePicker1.Text + "',N'" + textBox3.Text + "',N'" + textBox4.Text + "',N'" + textBox5.Text + "')";
                if (new Class_CRUDdb().exeData(str))
                {
                    MessageBox.Show("Đăng ký sinh viên ThÀNH CÔNG.");
                }
                else
                {
                    MessageBox.Show("Đăng ký sinh viên THẤT BẠI.");
                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại các trường dữ liệu.");
            }
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form_borrowReturn_timSV().ShowDialog();
        }
    }
}
