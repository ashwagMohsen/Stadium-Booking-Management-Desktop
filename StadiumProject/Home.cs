using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StadiumProject
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
           // panel3.BackColor = Color.FromArgb(30, Color.Green);
        }

        //private void guna2PictureBox2_Click(object sender, EventArgs e)
        //{
        //    //    MainForm MainForm1 = new MainForm();
        //    //    MainForm1.New();
        //    MainForm MainForm1 = new MainForm();
        //MainForm1.clearPanel();
        //    MainBooking formMain = new MainBooking() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        //formMain.FormBorderStyle = FormBorderStyle.None;
        //    MainForm1.addToPanel(formMain);
        //    formMain.Show();
        //    MessageBox.Show("enter");
        //}

        //private void guna2PictureBox1_Click(object sender, EventArgs e)
        //{
        //    MainForm MainForm1 = new MainForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        //    MainForm1.clearPanel();
        //    MainBooking formMain = new MainBooking() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        //    formMain.FormBorderStyle = FormBorderStyle.None;
        //    MainForm1.addToPanel(formMain);
        //    formMain.Show();
        //    MessageBox.Show("enter");
        //}

        //private void guna2PictureBox5_Click(object sender, EventArgs e)
        //{
        //    MainForm MainForm1 = new MainForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        //    MainForm1.clearPanel();
        //    MainBooking formMain = new MainBooking() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        //    formMain.FormBorderStyle = FormBorderStyle.None;
        //    MainForm1.addToPanel(formMain);
        //    formMain.Show();
        //    MessageBox.Show("enter");
        //}

        private void guna2PictureBox2_Click_1(object sender, EventArgs e)
        {
            int StudNum = 1;
            this.panel1.Controls.Clear();
            MainBooking formMain = new MainBooking(StudNum) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formMain.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(formMain);
            formMain.Show();
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox2_MouseHover(object sender, EventArgs e)
        {
           // panel3.Visible = true;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox2_MouseLeave(object sender, EventArgs e)
        {
          //  panel3.Visible = false;
        }

        private void guna2PictureBox2_MouseLeave(object sender, MouseEventArgs e)
        {
          
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            int StudNum = 2;
            this.panel1.Controls.Clear();
            MainBooking formMain = new MainBooking(StudNum) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formMain.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(formMain);
            formMain.Show();
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            int StudNum = 3;
            this.panel1.Controls.Clear();
            MainBooking formMain = new MainBooking(StudNum) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formMain.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(formMain);
            formMain.Show();
        }
    }
}
