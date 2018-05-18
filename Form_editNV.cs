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
    public partial class Form_editNV : Form
    {
        String MNV;
        public Form_editNV(String mnv)
        {
            InitializeComponent();
            MNV = mnv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (true)//Kiemtra input
            {
                String temp = "UPDATE Staff SET Tennv=N'" + textBox2.Text + "',Gioitinh=N'" + comboBox1.Text + "',Ngaysinh=N'"
                + dateTimePicker1.Text + "',Diachi=N'" + textBox3.Text + "',Gmail=N'" + textBox4.Text + "',Sdt=N'" + textBox5.Text
                +  "' WHERE MNV = N'" + MNV + "'";
                if (new Class_CRUDdb().exeData(temp))
                {
                    MessageBox.Show("Sửa nhân viên ThÀNH CÔNG.");
                }
                else
                {
                    MessageBox.Show("Sửa nhân viên THẤT BẠI.");
                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại các trường dữ liệu.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_editNV_Load(object sender, EventArgs e)
        {
            DataTable dt = new Class_CRUDdb().readData("SELECT * FROM Staff WHERE MNV='" + MNV + "'");
            DataRow dr = dt.Rows[0];
            textBox1.Text = dr["MNV"].ToString();
            textBox2.Text = dr["Tennv"].ToString();
            comboBox1.Text = dr["Gioitinh"].ToString();
            dateTimePicker1.Text = dr["Ngaysinh"].ToString();
            textBox3.Text = dr["Diachi"].ToString();
            textBox4.Text = dr["Gmail"].ToString();
            textBox5.Text = dr["Sdt"].ToString();
        }
    }
}
