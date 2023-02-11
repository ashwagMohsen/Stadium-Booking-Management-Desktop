using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace StadiumProject
{
    public partial class MainForm : Form
    {
        [DllImport("Gdi32.dll",EntryPoint ="CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
                   int nLeftrect,
        int nToprect,
          int nRightrect,
        int nBottomrect,
        int nwidthEllips,
        int nmheightEllips
            );
 
        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            panel_in.BorderStyle = (System.Drawing.Drawing2D.DashStyle)BorderStyle.None;
            panel_in.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.panel_in.Controls.Clear();
            Home formMain = new Home() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formMain.FormBorderStyle = FormBorderStyle.None;
            this.panel_in.Controls.Add(formMain);
            formMain.Show();

        }

        

        private void ButHome_Click(object sender, EventArgs e)
        {

            //    this.panel_in.Controls.Clear();
            //    Home formMain = new Home() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //    formMain.FormBorderStyle = FormBorderStyle.None;
            //    this.panel_in.Controls.Add(formMain);
            //    formMain.Show();


        }
        //public void New()
        //{
        //    this.panel_in.Controls.Clear();
        //    MainBooking formMain = new MainBooking() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        //    formMain.FormBorderStyle = FormBorderStyle.None;
        //    this.panel_in.Controls.Add(formMain);
        //    formMain.Show();
        //    MessageBox.Show("enter");
        //}
        //public void clearPanel()
        //{
        //   this.panel_in.Controls.Clear();
        //}
        //public void addToPanel(Control formMain )
        //{
        //    this.panel_in.Controls.Add(formMain);
        //}
        private void ButEmployee_Click(object sender, EventArgs e)
        {

            //this.panel_in.Controls.Clear();
            //Employee formMain = new Employee() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //formMain.FormBorderStyle = FormBorderStyle.None;
            //this.panel_in.Controls.Add(formMain);
            //formMain.Show();
        }

        private void ButServices_Click(object sender, EventArgs e)
        {

            //this.panel_in.Controls.Clear();
            //Services formMain = new Services() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //formMain.FormBorderStyle = FormBorderStyle.None;
            //this.panel_in.Controls.Add(formMain);
            //formMain.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            imgSlide.Visible = true;
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;
            guna2Button1.Checked = true;
            guna2Button3.Checked = false;
            guna2Button2.Checked = false;
        

            this.panel_in.Controls.Clear();
            Home formMain = new Home() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formMain.FormBorderStyle = FormBorderStyle.None;
            this.panel_in.Controls.Add(formMain);
            formMain.Show();
        }

        private void imgSlide2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            imgSlide.Visible = false;
            pictureBox3.Visible = true;
            pictureBox2.Visible = false;
            guna2Button1.Checked = false;
            guna2Button3.Checked = true;
            guna2Button2.Checked = false;
       
            this.panel_in.Controls.Clear();
            Employee formMain = new Employee() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formMain.FormBorderStyle = FormBorderStyle.None;
            this.panel_in.Controls.Add(formMain);
            formMain.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            imgSlide.Visible = false;
            pictureBox3.Visible = false;
            pictureBox2.Visible = true;
            guna2Button1.Checked = false;
            guna2Button3.Checked = false;
            guna2Button2.Checked = true;
         
            this.panel_in.Controls.Clear();
            Services formMain = new Services() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formMain.FormBorderStyle = FormBorderStyle.None;
            this.panel_in.Controls.Add(formMain);
            formMain.Show();
        }

        private void imgSlide1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            guna2Button1.Checked = false;
            guna2Button3.Checked = false;
            guna2Button2.Checked = false;
            imgSlide.Visible = false;
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;
        }
    }
}
