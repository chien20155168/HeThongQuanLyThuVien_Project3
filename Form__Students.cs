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
    public partial class Form__Students : UserControl
    {
        public Form__Students()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void refeshListView()
        {
            listView1.Items.Clear();
            DataTable dt = new Class_CRUDdb().readData("SELECT * FROM Student");
            int i = 0;
            if (dt != null)
                foreach (DataRow dr in dt.Rows)
                {
                    listView1.Items.Add(dr["MSV"].ToString());
                    listView1.Items[i].SubItems.Add(dr["Ten"].ToString());
                    listView1.Items[i].SubItems.Add(dr["Gioitinh"].ToString());
                    listView1.Items[i].SubItems.Add(dr["NgaySinh"].ToString());
                    listView1.Items[i].SubItems.Add(dr["Diachi"].ToString());
                    listView1.Items[i].SubItems.Add(dr["Email"].ToString());
                    listView1.Items[i].SubItems.Add(dr["Sdt"].ToString());
                    i++;
                }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            new Form_themSV().ShowDialog();
            refeshListView();
        }

        private void Form__Students_Load(object sender, EventArgs e)
        {
            refeshListView();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult dlr = MessageBox.Show("Bạn xoá SV này?", "Thông báo", MessageBoxButtons.YesNo);
                if (dlr == DialogResult.Yes)
                {
                    if (new Class_CRUDdb().exeData(exeStr))
                    {
                        //Xoa thanh cong
                        MessageBox.Show("Xóa SV THÀNH CÔNG!!");
                    }
                    else
                    {
                        //Xoa that bai.
                        MessageBox.Show("Xóa SV THẤT BẠI!!");
                    }
                    refeshListView();
                }
            }
            else
            {
                MessageBox.Show("Chọn sinh viên cần xóa thông tin.");
            }
        }
        public String exeStr;
        public string MSV;
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var item = e.Item;
            exeStr = "DELETE FROM Student WHERE MSV = N'" + item.Text + "'";
            MSV = item.Text;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                new Form_editSV(MSV).ShowDialog();
                refeshListView();
            }
            else
            {
                MessageBox.Show("Chọn sinh viên cần chỉnh sửa tt.");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            String temp = "SELECT * FROM Student WHERE " + comboBox1.Text + "= N'" + textBox1.Text + "'";
            DataTable dt = new Class_CRUDdb().readData(temp);
            int i = 0;
            if (dt != null)
                foreach (DataRow dr in dt.Rows)
                {
                    listView1.Items.Add(dr["MSV"].ToString());
                    listView1.Items[i].SubItems.Add(dr["Ten"].ToString());
                    listView1.Items[i].SubItems.Add(dr["Gioitinh"].ToString());
                    listView1.Items[i].SubItems.Add(dr["NgaySinh"].ToString());
                    listView1.Items[i].SubItems.Add(dr["DiaChi"].ToString());
                    listView1.Items[i].SubItems.Add(dr["Email"].ToString());
                    listView1.Items[i].SubItems.Add(dr["Sdt"].ToString());
                    i++;
                }
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            refeshListView();
        }
    }
}
