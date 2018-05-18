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
    public partial class Form_thongke_SVQuaHan : UserControl
    {
        static public ListView lv;
        String toMmail = null, fromMail=null;
        public String exeStr;

        public Form_thongke_SVQuaHan()
        {
            InitializeComponent();
            lv = listView1;
        }
        

        private void listView1_MouseClick(object sender, MouseEventArgs e){
            if (e.Button == MouseButtons.Right)
            {
                if (listView1.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void sendEmailToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            toMmail = null;
            DataTable dt =new Class_CRUDdb().readData(exeStr);
            DataRow dr = dt.Rows[0];
            if (dt != null)
            {
                toMmail = dr["Email"].ToString(); ;
            }

            fromMail = null;
            exeStr = "SELECT Gmail FROM Staff WHERE MNV = N'" + Form_Login.MNV + "'";
            dt= new Class_CRUDdb().readData(exeStr);
            dr= dt.Rows[0];
            if (dt != null)
            {
                fromMail = dr["Gmail"].ToString(); ;
            }
            new Form_sendEmail(toMmail,fromMail).ShowDialog();
        }
        
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            exeStr = "SELECT Email FROM Student WHERE MSV = N'" + e.Item.Text + "'";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
