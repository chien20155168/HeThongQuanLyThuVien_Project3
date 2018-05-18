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
    public partial class Form_thongke_LichSu : UserControl
    {
        static public ListView lv;
        public Form_thongke_LichSu()
        {
            InitializeComponent();
            lv = listView1;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String exeStr = "DELETE FROM ReturnedHistory ";
            new Class_CRUDdb().exeData(exeStr);
            Form_Statistics.refeshLichsuTraSach();

        }
    }
}
