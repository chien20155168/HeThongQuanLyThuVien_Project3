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
    public partial class Form_thongke_SachDaMuon : UserControl
    {
        static public ListView lv;
        public Form_thongke_SachDaMuon()
        {
            InitializeComponent();
            lv = listView1;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
