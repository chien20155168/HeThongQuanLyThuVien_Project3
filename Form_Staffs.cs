using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib_Manage
{
    public partial class Form_Staffs : UserControl
    {
        public Form_Staffs()
        {
            InitializeComponent();
        }

        public void refeshListView()
        {
            listView1.Items.Clear();
            DataTable dt = new Class_CRUDdb().readData("SELECT * FROM Staff");
            int i = 0;
            if (dt != null)
                foreach (DataRow dr in dt.Rows)
                {
                    listView1.Items.Add(dr["MNV"].ToString());
                    listView1.Items[i].SubItems.Add(dr["Tennv"].ToString());
                    listView1.Items[i].SubItems.Add(dr["Gioitinh"].ToString());
                    listView1.Items[i].SubItems.Add(dr["NgaySinh"].ToString());
                    listView1.Items[i].SubItems.Add(dr["Diachi"].ToString());
                    listView1.Items[i].SubItems.Add(dr["Gmail"].ToString());
                    listView1.Items[i].SubItems.Add(dr["Sdt"].ToString());
                    i++;
                }
        }
        
        private void Form_Staffs_Load(object sender, EventArgs e)
        {
            refeshListView();
            String temp = "SELECT * FROM Staff WHERE MNV= N'" + Form_Login.MNV + "'";
            DataTable dt = new Class_CRUDdb().readData(temp);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                label9.Text = dr["MNV"].ToString();
                label12.Text = dr["Tennv"].ToString();
                label18.Text = dr["Gioitinh"].ToString();
                label14.Text = dr["Ngaysinh"].ToString();
                label13.Text = dr["Diachi"].ToString();
                label16.Text = dr["Gmail"].ToString();
                label15.Text = dr["Sdt"].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Delete staff
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult dlr = MessageBox.Show("Bạn xoá NV này?", "Thông báo", MessageBoxButtons.YesNo);
                if (dlr == DialogResult.Yes)
                {
                    if (new Class_CRUDdb().exeData(exeStr))
                    {
                        //Xoa thanh cong
                        MessageBox.Show("Xóa NV THÀNH CÔNG!!");
                    }
                    else
                    {
                        //Xoa that bai.
                        MessageBox.Show("Xóa NV THẤT BẠI!!");
                    }
                    refeshListView();
                }
            }
            else
            {
                MessageBox.Show("Chọn nhân viên cần xóa tt.");
            }
        }

        public String exeStr=null;
        private void listView1_ItemSelectionChanged_1(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var item = e.Item;
            exeStr = "DELETE FROM Staff WHERE MNV = N'" + item.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Edit Staff
            new Form_editNV(Form_Login.MNV).ShowDialog();
            refeshListView();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Search Staff
            listView1.Items.Clear();
            String temp = "SELECT * FROM Staff WHERE " + comboBox1.Text + "= N'" + textBox1.Text + "'";
            DataTable dt = new Class_CRUDdb().readData(temp);
            int i = 0;
            if (dt != null)
                foreach (DataRow dr in dt.Rows)
                {
                    listView1.Items.Add(dr["MNV"].ToString());
                    listView1.Items[i].SubItems.Add(dr["Tennv"].ToString());
                    listView1.Items[i].SubItems.Add(dr["Gioitinh"].ToString());
                    listView1.Items[i].SubItems.Add(dr["Ngaysinh"].ToString());
                    listView1.Items[i].SubItems.Add(dr["Diachi"].ToString());
                    listView1.Items[i].SubItems.Add(dr["Gmail"].ToString());
                    listView1.Items[i].SubItems.Add(dr["Sdt"].ToString());
                    i++;
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form_ChancePass().ShowDialog();
        }
    }
}
