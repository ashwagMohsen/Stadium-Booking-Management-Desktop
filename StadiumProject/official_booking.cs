
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StadiumProject
{
    public partial class official_booking : Form
    {


      
       // MainBooking mainBook = new MainBooking();
        //string date1 = mainBook.getParamiter();
        //string time1 = mainBook.getParamiter2();
    
        double number_h, number_p, number_earnset,number_residual;
        int month, year, Num;
        static string Hour;
        static int Price = 8000;
        static int StudNum;
        //static official_booking()
        //{

        //}
        public official_booking(string date11, string hour, string range, int Month,int Year,int num,int studNum)
        {
            InitializeComponent();
            date.Text = date11;
            time.Text = range;
            month = Month;
            year = Year;
            Num=num;
            Hour = hour;
            StudNum = studNum;
         
        }



        private void Guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        //private void NumOfHours_TextChanged(object sender, EventArgs e)
        //{
        //    NumOfHours.Text = NumOfHours.Text;
        //}

        private void Done_TextChanged(object sender, EventArgs e)
        {

        }

        //private void Plus_button_Click(object sender, EventArgs e)
        //{
        //    number_h += 1;
        //    NumOfHours.Text = number_h.ToString();
        //    number_p += 8000;
        //    price.Text = number_p.ToString();
        //}

        //private void Minus_button_Click(object sender, EventArgs e)
        //{
        //    number_h -= 1;
        //    NumOfHours.Text = number_h.ToString();
        //    number_p -= 8000;
        //    price.Text = number_p.ToString();
        //}

        //private void Price_TextChanged(object sender, EventArgs e)
        //{
            
        //}

        private void Hours_panel_Paint(object sender, PaintEventArgs e)
        {

        }



        //private void Earnest_amount_TextChanged(object sender, EventArgs e)
        //{
        //    earnest_amount.Text = earnest_amount.Text;
            
        //}

        //private void Residual_amount_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void date_Click(object sender, EventArgs e)
        {

        }

        private void time_Click(object sender, EventArgs e)
        {

        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            
    
        }

        //private void earnest_amount_TextChanged_1(object sender, EventArgs e)
        //{
        //    earnest_amount.Text = earnest_amount.Text;
        //    residual_amount.Text = (int.Parse(price.Text) - int.Parse(earnest_amount.Text)).ToString();
        //}

        private void confirm_button_Click_1(object sender, EventArgs e)
        {
            if (StudNum == 1)
            {
                DBClass.ExcuteNonQuery("[sp_reg1_Insert]",
                DBClass.CreateParameter("@full_name", FullName.Text),
               DBClass.CreateParameter("@date", date.Text),
               DBClass.CreateParameter("@mobile", guna2TextBox3.Text),
               DBClass.CreateParameter("@Email", guna2TextBox2.Text),
               DBClass.CreateParameter("@hours", NumOfHours.Text),
               DBClass.CreateParameter("@price", price.Text),
               DBClass.CreateParameter("@earnest", earnest_amount.Text),
               DBClass.CreateParameter("@residual", residual_amount.Text),
               DBClass.CreateParameter("@time", Hour),
                DBClass.CreateParameter("@month", month),
                 DBClass.CreateParameter("@year", year),
           DBClass.CreateParameter("@num", Num),
             DBClass.CreateParameter("@hourRange", time.Text));
                this.guna2Panel1.Controls.Clear();

                Invoices formMain = new Invoices(date.Text, Hour,StudNum) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                formMain.FormBorderStyle = FormBorderStyle.None;
                this.guna2Panel1.Controls.Add(formMain);
                formMain.Show();
            }
            else if (StudNum == 2)
            {
                DBClass.ExcuteNonQuery("[sp_reg2_Insert]",
                DBClass.CreateParameter("@full_name", FullName.Text),
               DBClass.CreateParameter("@date", date.Text),
               DBClass.CreateParameter("@mobile", guna2TextBox3.Text),
               DBClass.CreateParameter("@Email", guna2TextBox2.Text),
               DBClass.CreateParameter("@hours", NumOfHours.Text),
               DBClass.CreateParameter("@price", price.Text),
               DBClass.CreateParameter("@earnest", earnest_amount.Text),
               DBClass.CreateParameter("@residual", residual_amount.Text),
               DBClass.CreateParameter("@time", Hour),
                DBClass.CreateParameter("@month", month),
                 DBClass.CreateParameter("@year", year),
           DBClass.CreateParameter("@num", Num),
             DBClass.CreateParameter("@hourRange", time.Text));
                this.guna2Panel1.Controls.Clear();

                Invoices formMain = new Invoices(date.Text, Hour, StudNum) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                formMain.FormBorderStyle = FormBorderStyle.None;
                this.guna2Panel1.Controls.Add(formMain);
                formMain.Show();
            }
            else
            {
                DBClass.ExcuteNonQuery("[sp_reg3_Insert]",
                DBClass.CreateParameter("@full_name", FullName.Text),
               DBClass.CreateParameter("@date", date.Text),
               DBClass.CreateParameter("@mobile", guna2TextBox3.Text),
               DBClass.CreateParameter("@Email", guna2TextBox2.Text),
               DBClass.CreateParameter("@hours", NumOfHours.Text),
               DBClass.CreateParameter("@price", price.Text),
               DBClass.CreateParameter("@earnest", earnest_amount.Text),
               DBClass.CreateParameter("@residual", residual_amount.Text),
               DBClass.CreateParameter("@time", Hour),
                DBClass.CreateParameter("@month", month),
                 DBClass.CreateParameter("@year", year),
           DBClass.CreateParameter("@num", Num),
             DBClass.CreateParameter("@hourRange", time.Text));
                this.guna2Panel1.Controls.Clear();

                Invoices formMain = new Invoices(date.Text, Hour, StudNum) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                formMain.FormBorderStyle = FormBorderStyle.None;
                this.guna2Panel1.Controls.Add(formMain);
                formMain.Show();
            }
          
            MessageBox.Show("The Booking Process done successfully.");
        }

       

        //private void price_TextChanged_1(object sender, EventArgs e)
        //{

        //}

        //private void earnest_amount_TextChanged_2(object sender, EventArgs e)
        //{
        //    //try
        //    //{

        //        //earnest_amount.Text = earnest_amount.Text;
        //        //residual_amount.Text = Convert.ToString(Convert.ToInt32(price.Text) - Convert.ToInt32(earnest_amount.Text));
        //    //}
        //    //catch(Exception ex)
        //    //{
        //    //    MessageBox.Show(ex.Message);
        //    //}
        //}

        //private void residual_amount_TextChanged_1(object sender, EventArgs e)
        //{

        //}

        //private void date_TextChanged(object sender, EventArgs e)
        //{
         
         
        //}

        //private void time_TextChanged(object sender, EventArgs e)
        //{
           
        //}

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.guna2Panel1.Controls.Clear();
            MainBooking formMain = new MainBooking(StudNum) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formMain.FormBorderStyle = FormBorderStyle.None;
            this.guna2Panel1.Controls.Add(formMain);
            formMain.Show();
        }

        private void earnest_amount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //
                earnest_amount.Text = earnest_amount.Text;
                residual_amount.Text = (Price- int.Parse(earnest_amount.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void residual_amount_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void guna2Panel1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void guna2Panel1_MouseUp_1(object sender, MouseEventArgs e)
        {

        }

        private void guna2Panel1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_MouseUp_1(object sender, EventArgs e)
        {
            if (FullName.Text != "" && guna2TextBox2.Text != "" && guna2TextBox3.Text != "" && earnest_amount.Text != "")
            {
                confirm_button.Enabled = true;
            }
        }

        private void price_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void change_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.guna2Panel1.Controls.Clear();
            Home formMain = new Home() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formMain.FormBorderStyle = FormBorderStyle.None;
            this.guna2Panel1.Controls.Add(formMain);
            formMain.Show();
        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void official_booking_Load(object sender, EventArgs e)
        {
            confirm_button.Enabled = false;
          
        }
    }
}
