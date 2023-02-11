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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void ButAddNew_Click(object sender, EventArgs e)
        {

        }

        private void ButAddNew_Click_1(object sender, EventArgs e)
        {
            this.panelEmp.Controls.Clear();
            AddStaff formMain = new AddStaff() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formMain.FormBorderStyle = FormBorderStyle.None;
            this.panelEmp.Controls.Add(formMain);
            formMain.Show();
        }
    }
}
