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
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void ButAddNew_Click_1(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            AddService formMain = new AddService() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formMain.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(formMain);
            formMain.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
