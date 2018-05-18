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
    public partial class Form_Statistics : UserControl
    {
        public Form_Statistics()
        {
            InitializeComponent();
            button3.BackColor = Color.CadetBlue;
            refeshSachDaMuon();
        }

        public void ColorClear()
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
        }
        static public void refeshSachDaMuon()
        {
            Form_thongke_SachDaMuon.lv.Items.Clear();
            DataTable dt = new Class_CRUDdb().readData("SELECT * FROM Books");
            int i = 0;
            if (dt != null)
                foreach (DataRow dr in dt.Rows)
                {
                    Form_thongke_SachDaMuon.lv.Items.Add(dr["MS"].ToString());
                    Form_thongke_SachDaMuon.lv.Items[i].SubItems.Add(dr["Ten"].ToString());
                    Form_thongke_SachDaMuon.lv.Items[i].SubItems.Add(dr["TacGia"].ToString());
                    Form_thongke_SachDaMuon.lv.Items[i].SubItems.Add(dr["NXB"].ToString());
                    int conlai = Int32.Parse(dr["TongSach"].ToString()) - Int32.Parse(dr["DaMuon"].ToString());
                    Form_thongke_SachDaMuon.lv.Items[i].SubItems.Add(conlai.ToString());
                    i++;
                }
        }
        static public void refeshLichsuTraSach()
        {
            Form_thongke_LichSu.lv.Items.Clear();
            DataTable dt = new Class_CRUDdb().readData("SELECT * FROM ReturnedHistory");
            int i = 0;
            if (dt != null)
                foreach (DataRow dr in dt.Rows)
                {
                    Form_thongke_LichSu.lv.Items.Add(dr["MSV"].ToString());
                    Form_thongke_LichSu.lv.Items[i].SubItems.Add(dr["MS"].ToString());
                    Form_thongke_LichSu.lv.Items[i].SubItems.Add(dr["MNV"].ToString());
                    Form_thongke_LichSu.lv.Items[i].SubItems.Add(dr["NgayMuon"].ToString());
                    Form_thongke_LichSu.lv.Items[i].SubItems.Add(dr["HanTra"].ToString());
                    Form_thongke_LichSu.lv.Items[i].SubItems.Add(dr["NgayTra"].ToString());
                    i++;
                }
        }
        static public void refeshSinhvienQuahan()
        {
            Form_thongke_SVQuaHan.lv.Items.Clear();
            DataTable dt = new Class_CRUDdb().readData("SELECT * FROM BorrowReturn");
            int i = 0;
            if (dt != null)
                foreach (DataRow dr in dt.Rows)
                {
                    int result = DateTime.Compare(DateTime.Parse(dr["HanTra"].ToString()), DateTime.Now);
                    if (result < 0)
                    {
                        Form_thongke_SVQuaHan.lv.Items.Add(dr["MSV"].ToString());
                        Form_thongke_SVQuaHan.lv.Items[i].SubItems.Add(dr["MS"].ToString());
                        Form_thongke_SVQuaHan.lv.Items[i].SubItems.Add(dr["MNV"].ToString());
                        Form_thongke_SVQuaHan.lv.Items[i].SubItems.Add(dr["NgayMuon"].ToString());
                        Form_thongke_SVQuaHan.lv.Items[i].SubItems.Add(dr["HanTra"].ToString());
                        i++;
                    }
                }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ColorClear();
            button3.BackColor = Color.CadetBlue;
            form_thongke_SachDaMuon1.BringToFront();
            refeshSachDaMuon();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorClear();
            button1.BackColor = Color.CadetBlue;
            form_thongke_SVQuaHan1.BringToFront();
            refeshSinhvienQuahan();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorClear();
            button2.BackColor = Color.CadetBlue;
            form_thongke_LichSu1.BringToFront();
            refeshLichsuTraSach();


        }

        private void Form_Statistics_Load(object sender, EventArgs e)
        {

        }

        private void form_thongke_SachDaMuon1_Load(object sender, EventArgs e)
        {

        }
    }
}
