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
    public partial class Form_ChancePass : Form
    {
        public Form_ChancePass()
        {
            InitializeComponent();
        }
        public Boolean Test()
        {
            String temp = "SELECT * FROM Staff WHERE MNV = N'" + Form_Login.MNV + "'";
            DataTable dt = new Class_CRUDdb().readData(temp);
            DataRow dr = dt.Rows[0];
            if (!textBox1.Text.Equals(dr["Pass"].ToString())) return false;
            if (!textBox2.Text.Equals(textBox3.Text)) return false;
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Kiem tra mat khau cu 
            //So sanh mat khau moi
            //doi mat khau
            if (Test())
            {
                String temp = "UPDATE Staff SET Pass=N'" + textBox2.Text + "' WHERE MNV = N'" + Form_Login.MNV + "'";
                if (new Class_CRUDdb().exeData(temp))
                {
                    MessageBox.Show("Đổi Pass ThÀNH CÔNG.");
                }
                else
                {
                    MessageBox.Show("Đổi Pass THẤT BẠI.");
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
    }
}
