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
    public partial class Home : Form
    {
        Form_Login loginform;
        public Home(Form_Login loginform1)
        {
            InitializeComponent();
            button1.BackColor = Color.CadetBlue;
            loginform = loginform1;
        }
        
        public void ColorClear()
        {
            button1.BackColor = panel1.BackColor;
            button6.BackColor = panel1.BackColor;
            button5.BackColor = panel1.BackColor;
            button2.BackColor = panel1.BackColor;
            button3.BackColor = panel1.BackColor;
            button7.BackColor = panel1.BackColor;
        }

        private void button1_Click_1(object sender, EventArgs e){
            //Books
            ColorClear();
            button1.BackColor = Color.CadetBlue;
            form__Books1.BringToFront();
            form__Books1.refeshListView();

        }

        private void button6_Click(object sender, EventArgs e){
            //Student
            ColorClear();
            button6.BackColor = Color.CadetBlue;
            form__Students1.BringToFront();
            form__Students1.refeshListView();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //borrow
            ColorClear();
            button5.BackColor = Color.CadetBlue;
            form__BorrowReturn1.BringToFront();
            form__BorrowReturn1.refeshListView();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //statics
            ColorClear();
            button2.BackColor = Color.CadetBlue;
            form_Statistics1.BringToFront();
            Form_Statistics.refeshSachDaMuon();
            Form_Statistics.refeshLichsuTraSach();
            Form_Statistics.refeshSinhvienQuahan();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //staff
            ColorClear();
            button3.BackColor = Color.CadetBlue;
            form_Staffs1.BringToFront();
            form_Staffs1.refeshListView();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ColorClear();
            button7.BackColor = Color.CadetBlue;
            this.Close();
            loginform.Show();
            Form_Login.tbPass.Text = null ;

        }
        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        int mov, x, y;

        private void Home_Load_1(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[1].WorkingArea.Location;
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            mov = 1; x = e.X; y = e.Y;
        }

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (mov == 1) SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
        }

        private void panel1_MouseUp_1(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
