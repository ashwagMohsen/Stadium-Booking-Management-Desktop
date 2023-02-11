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
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
        }

        private void ButAddImg_Click(object sender, EventArgs e)
        {
            string imgLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imgLocation = dialog.FileName;
                    Personal_IMG.ImageLocation = imgLocation;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "123@gmail.com")
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = "123@gmail.com";
                textBoxEmail.ForeColor = Color.Silver;
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButAddNew_Click(object sender, EventArgs e)
        {
            this.guna2Panel1.Controls.Clear();
            Employee formMain = new Employee() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formMain.FormBorderStyle = FormBorderStyle.None;
            this.guna2Panel1.Controls.Add(formMain);
            formMain.Show();
            MessageBox.Show("The addition Process done successfully.");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.guna2Panel1.Controls.Clear();
            Employee formMain = new Employee() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formMain.FormBorderStyle = FormBorderStyle.None;
            this.guna2Panel1.Controls.Add(formMain);
            formMain.Show();
          
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
