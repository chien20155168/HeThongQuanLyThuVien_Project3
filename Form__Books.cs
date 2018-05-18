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
    public partial class Form__Books : UserControl
    {
        public Form__Books()
        {
            InitializeComponent();
        }
        public void refeshListView()
        {
            listView1.Items.Clear();
            DataTable dt = new Class_CRUDdb().readData("SELECT * FROM Books");
            int i = 0;
            if (dt != null)
                foreach (DataRow dr in dt.Rows)
                {
                    listView1.Items.Add(dr["MS"].ToString());
                    listView1.Items[i].SubItems.Add(dr["Ten"].ToString());
                    listView1.Items[i].SubItems.Add(dr["TacGia"].ToString());
                    listView1.Items[i].SubItems.Add(dr["NXB"].ToString());
                    listView1.Items[i].SubItems.Add(dr["TongSach"].ToString());
                    listView1.Items[i].SubItems.Add(dr["DaMuon"].ToString());
                    i++;
                }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            new Form_themBook().ShowDialog();
            refeshListView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                new Form_editS(MS).ShowDialog();
                refeshListView();
            }
            else
            {
                MessageBox.Show("Chọn nhân viên cần chỉnh sửa tt.");
            }
        }

        private void Form__Books_Load(object sender, EventArgs e)
        {
            refeshListView();
        }

        public String exeStr = null;
        public String MS;
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var item = e.Item;
            exeStr = "DELETE FROM Books WHERE MS = N'" + item.Text + "'";
            MS = item.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult dlr = MessageBox.Show("Bạn xoá tt sách này?", "Thông báo", MessageBoxButtons.YesNo);
                if (dlr == DialogResult.Yes)
                {
                    if (new Class_CRUDdb().exeData(exeStr))
                    {
                        //Xoa thanh cong
                        MessageBox.Show("Xóa tt sách THÀNH CÔNG!!");
                    }
                    else
                    {
                        //Xoa that bai.
                        MessageBox.Show("Xóa tt sách THẤT BẠI!!");
                    }
                    refeshListView();
                }
            }
            else
            {
                MessageBox.Show("Chọn sách cần xóa tt.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            String temp = "SELECT * FROM Books WHERE " + comboBox1.Text + "= N'" + textBox1.Text + "'";
            DataTable dt = new Class_CRUDdb().readData(temp);
            int i = 0;
            if (dt != null)
                foreach (DataRow dr in dt.Rows)
                {
                    listView1.Items.Add(dr["MS"].ToString());
                    listView1.Items[i].SubItems.Add(dr["Ten"].ToString());
                    listView1.Items[i].SubItems.Add(dr["TacGia"].ToString());
                    listView1.Items[i].SubItems.Add(dr["NXB"].ToString());
                    listView1.Items[i].SubItems.Add(dr["TongSach"].ToString());
                    listView1.Items[i].SubItems.Add(dr["DaMuon"].ToString());
                    i++;
                }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            refeshListView();
        }
    }
}
