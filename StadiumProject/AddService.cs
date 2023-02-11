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
    public partial class AddService : Form
    {
        public AddService()
        {
            InitializeComponent();
        }

        private void ButAddImgSer_Click(object sender, EventArgs e)
        {
            string imgLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imgLocation = dialog.FileName;
                    Service_IMG.ImageLocation = imgLocation;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.guna2Panel1.Controls.Clear();
            Services formMain = new Services() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formMain.FormBorderStyle = FormBorderStyle.None;
            this.guna2Panel1.Controls.Add(formMain);
            formMain.Show();
        }

        private void ButAddNew_Click(object sender, EventArgs e)
        {
            this.guna2Panel1.Controls.Clear();
            Services formMain = new Services() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formMain.FormBorderStyle = FormBorderStyle.None;
            this.guna2Panel1.Controls.Add(formMain);
            formMain.Show();
        }
    }
}
