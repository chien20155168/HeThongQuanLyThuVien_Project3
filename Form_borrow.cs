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
    public partial class Form_borrow : Form
    {
        public Form_borrow()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Muon Sach
            string MS = textBox4.Text;
            string temp = "INSERT INTO BorrowReturn (MSV,MS,MNV,NgayMuon,HanTra) VALUES" + " (N'" + textBox1.Text + "',N'" +
                textBox4.Text + "',N'" + Form_Login.MNV + "',N'" + dateTimePicker1.Text + "',N'" + dateTimePicker2.Text + "')";
            if (true) //kiem tra maS va maSV
            {
                if(new Class_CRUDdb().exeData(temp))
                {
                    DataTable dt = new Class_CRUDdb().readData("SELECT * FROM Books WHERE MS='" + MS + "'");
                    DataRow dr = dt.Rows[0];
                    int sachDaMuon = Int32.Parse(dr["DaMuon"].ToString());
                    sachDaMuon++;

                    String temp2= "UPDATE Books SET DaMuon=" + sachDaMuon + " WHERE MS = N'" + MS + "'";
                    new Class_CRUDdb().exeData(temp2);
                    MessageBox.Show("Mượn Sách THÀNH CÔNG!");
                }
                else
                {
                    MessageBox.Show("Mượn Sách THẤT BẠI!");
                }
            }
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            new Form_borrowReturn_timSV().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form_BorowReturnTimSach().ShowDialog();
        }
    }
}
