using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StadiumProject
{
    public partial class Invoices : Form
    {
       
        public Invoices(string date11, string time11,int studNum)
        {
            InitializeComponent();
            if (studNum == 1)
            {
                SqlDataReader reader = DBClass.ExcuteReader("sp_reg1_select_By_Time_datte",
               DBClass.CreateParameter("@date", date11),
               DBClass.CreateParameter("@time", time11));
                DataTable dt = new DataTable();

                dt.Load(reader);
                dataGridView1.DataSource = dt;

                SqlDataReader reader2 = DBClass.ExcuteReader("sp_reg1_select_By_Time_datte",
                    DBClass.CreateParameter("@date", date11),
                    DBClass.CreateParameter("@time", time11));
                while (reader2.Read())
                {
                    label11.Text = reader2["price"].ToString();
                }
            }
            else if (studNum == 2)
            {
                SqlDataReader reader = DBClass.ExcuteReader("sp_reg2_select_By_Time_datte",
               DBClass.CreateParameter("@date", date11),
               DBClass.CreateParameter("@time", time11));
                DataTable dt = new DataTable();

                dt.Load(reader);
                dataGridView1.DataSource = dt;

                SqlDataReader reader2 = DBClass.ExcuteReader("sp_reg2_select_By_Time_datte",
                    DBClass.CreateParameter("@date", date11),
                    DBClass.CreateParameter("@time", time11));
                while (reader2.Read())
                {
                    label11.Text = reader2["price"].ToString();
                }
            }
            else
            {
                SqlDataReader reader = DBClass.ExcuteReader("sp_reg3_select_By_Time_datte",
               DBClass.CreateParameter("@date", date11),
               DBClass.CreateParameter("@time", time11));
                DataTable dt = new DataTable();

                dt.Load(reader);
                dataGridView1.DataSource = dt;

                SqlDataReader reader2 = DBClass.ExcuteReader("sp_reg3_select_By_Time_datte",
                    DBClass.CreateParameter("@date", date11),
                    DBClass.CreateParameter("@time", time11));
                while (reader2.Read())
                {
                    label11.Text = reader2["price"].ToString();
                }
            }
           



        }              

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.guna2Panel1.Controls.Clear();
            Home formMain = new Home() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formMain.FormBorderStyle = FormBorderStyle.None;
            this.guna2Panel1.Controls.Add(formMain);
            formMain.Show();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
