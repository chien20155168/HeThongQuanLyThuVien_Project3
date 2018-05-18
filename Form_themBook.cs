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
    public partial class Form_themBook : Form
    {
        public Form_themBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int TongSach = Int32.Parse(textBox5.Text);
            if (true)//Kiemtra input
            {
                String str = "INSERT INTO Books (MS,Ten,TacGia,NXB,TongSach,DaMuon) VALUES" +
                " (N'" + textBox1.Text + "',N'" + textBox2.Text+ "',N'" + textBox3.Text + "',N'" +
                textBox4.Text + "'," + TongSach + ",0)";
                if (new Class_CRUDdb().exeData(str))
                {
                    MessageBox.Show("Thêm sách ThÀNH CÔNG.");
                }
                else
                {
                    MessageBox.Show("Thêm sách THẤT BẠI.");
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

        private void button3_Click(object sender, EventArgs e)
        {
            new Form_BorowReturnTimSach().ShowDialog(); ;
        }
    }
}
