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
    public partial class Form_themStaff : Form
    {
        public Form_themStaff()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Boolean Test()
        {
            if (textBox7.Text == "" || textBox6.Text == "" || textBox1.Text == "") return false;
            if (!textBox7.Text.Equals(textBox6.Text)) return false;
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Test())//Kiemtra input
            {
                String str = "INSERT INTO Staff (MNV,Tennv,Gioitinh,Ngaysinh,Diachi,Gmail,Sdt,Pass) VALUES" +
                " (N'" + textBox1.Text + "',N'" + textBox2.Text + "',N'" + comboBox1.Text + "',N'" +
                dateTimePicker1.Text + "',N'" + textBox3.Text + "',N'" + textBox4.Text + "',N'" + textBox5.Text + "',N'" + textBox6.Text+"')";
                if (new Class_CRUDdb().exeData(str))
                {
                    MessageBox.Show("Đăng ký nhân viên ThÀNH CÔNG.");
                }
                else
                {
                    MessageBox.Show("Đăng ký nhân viên THẤT BẠI.");
                }

            }
            else
            {
                MessageBox.Show("Kiểm tra lại các trường dữ liệu.");
            }
        }
    }
}
