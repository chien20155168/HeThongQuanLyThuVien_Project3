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
    public partial class Form__BorrowReturn : UserControl
    {

        public String exeDelStr = null;
        public String exeSaveStr = null;
        public Form__BorrowReturn()
        {
            InitializeComponent();
            refeshListView();
        }
        public void refeshListView()
        {
            listView1.Items.Clear();
            DataTable dt = new Class_CRUDdb().readData("SELECT * FROM BorrowReturn");
            int i = 0;
            if (dt != null)
                foreach (DataRow dr in dt.Rows)
                {
                    listView1.Items.Add(dr["MSV"].ToString());
                    listView1.Items[i].SubItems.Add(dr["MS"].ToString());
                    listView1.Items[i].SubItems.Add(dr["MNV"].ToString());
                    listView1.Items[i].SubItems.Add(dr["NgayMuon"].ToString());
                    listView1.Items[i].SubItems.Add(dr["HanTra"].ToString());
                    i++;
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Muon Sach
            Form_borrow muonS= new Form_borrow();
            muonS.ShowDialog();
            refeshListView();
        }
        public String curentMS = null;
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //click to row in listview
            var item = e.Item;
            exeDelStr = "DELETE FROM BorrowReturn WHERE MSV = N'" + item.Text + "' AND MS=N'" 
                + item.SubItems[1].Text + "' AND  MNV=N'" + item.SubItems[2].Text + "' AND NgayMuon=N'" 
                + item.SubItems[3].Text + "' AND  HanTra=N'" + item.SubItems[4].Text + "'";

            exeSaveStr = "INSERT INTO ReturnedHistory (MSV,MS,MNV,NgayMuon,HanTra,NgayTra) VALUES" +
                " (N'" + item.Text + "',N'" + item.SubItems[1].Text + "',N'" + item.SubItems[2].Text + "',N'" +
                item.SubItems[3].Text + "',N'" + item.SubItems[4].Text + "',N'"+DateTime.Now+"')";
            curentMS = item.SubItems[1].Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Tra sach
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult dlr = MessageBox.Show("Bạn muốn trả sách này?", "Thông báo", MessageBoxButtons.YesNo);
                if (dlr == DialogResult.Yes)
                {
                    if (new Class_CRUDdb().exeData(exeDelStr))
                    {
                        new Class_CRUDdb().exeData(exeSaveStr);

                        DataTable dt = new Class_CRUDdb().readData("SELECT * FROM Books WHERE MS='" + curentMS + "'");
                        DataRow dr = dt.Rows[0];
                        int sachDaMuon = Int32.Parse(dr["DaMuon"].ToString());
                        sachDaMuon--;
                        String temp2 = "UPDATE Books SET DaMuon=" + sachDaMuon + " WHERE MS = N'" + curentMS + "'";
                        new Class_CRUDdb().exeData(temp2);

                        MessageBox.Show("Trả sách THÀNH CÔNG!!");
                    }
                    else{
                        MessageBox.Show("Trả sách THẤT BẠI!!");
                    }
                    refeshListView();
                }
            }
            else
            {
                MessageBox.Show("Chọn sách muốn trả.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Search
            String type;
            if (radioButton1.Checked)
            {
                type = "MSV";
            }
            else if (radioButton2.Checked)
            {
                type = "MS";
            }
            else
            {
                type = "MNV";
            }

            listView1.Items.Clear();
            String temp = "SELECT * FROM BorrowReturn WHERE " + type + "= N'" + textBox1.Text+"'";
            DataTable dt = new Class_CRUDdb().readData(temp);
            int i = 0;
            if (dt != null)
                foreach (DataRow dr in dt.Rows)
                {
                    listView1.Items.Add(dr["MSV"].ToString());
                    listView1.Items[i].SubItems.Add(dr["MS"].ToString());
                    listView1.Items[i].SubItems.Add(dr["MNV"].ToString());
                    listView1.Items[i].SubItems.Add(dr["NgayMuon"].ToString());
                    listView1.Items[i].SubItems.Add(dr["HanTra"].ToString());
                    i++;
                }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

        private void Form__BorrowReturn_Load(object sender, EventArgs e)
        {
            refeshListView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            refeshListView();
        }
    }
}
