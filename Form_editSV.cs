using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib_Manage
{
    public partial class Form_editSV : Form
    {
        String MSV;
        public Form_editSV(String msv)
        {
            InitializeComponent();
            MSV = msv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (true)//Kiemtra input
            {
                String temp = "UPDATE Student SET Ten=N'" + textBox2.Text + "',Gioitinh=N'" + comboBox1.Text + "',Ngaysinh=N'"
                + dateTimePicker1.Text + "',DiaChi=N'" + textBox3.Text + "',Email=N'" + textBox4.Text + "',Sdt=N'" + textBox5.Text
                + "' WHERE MSV = N'"+ MSV + "'";
                if (new Class_CRUDdb().exeData(temp))
                {
                    MessageBox.Show("Sửa sinh viên ThÀNH CÔNG.");
                }
                else
                {
                    MessageBox.Show("Sửa sinh viên THẤT BẠI.");
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_editSV_Load(object sender, EventArgs e)
        {
            DataTable dt = new Class_CRUDdb().readData("SELECT * FROM Student WHERE MSV='"+MSV+"'");
            DataRow dr = dt.Rows[0];
            textBox1.Text = dr["MSV"].ToString();
            textBox2.Text = dr["Ten"].ToString();
            comboBox1.Text = dr["Gioitinh"].ToString();
            dateTimePicker1.Text = dr["Ngaysinh"].ToString();
            textBox3.Text = dr["DiaChi"].ToString();
            textBox4.Text = dr["Email"].ToString();
            textBox5.Text = dr["Sdt"].ToString();
            
        }
    }
}
