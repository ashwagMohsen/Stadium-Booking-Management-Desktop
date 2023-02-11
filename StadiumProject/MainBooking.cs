
    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StadiumProject
{
    public partial class MainBooking : Form
    {

        int month, year;
        static string num1;
        static string range;
        static string hour;
        static int StudNum;
        static bool result;
        public MainBooking(int studNum)
        {
            InitializeComponent();
            StudNum = studNum;
        }

        private void MainBooking_Load(object sender, EventArgs e)
        {
            displayDays();
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthName + " " + year;
            DateTime StartOfTheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            //count thloth is second day in week but it is 4 so that we added 2 to make it true
            int DaysOfTheWeek = Convert.ToInt32(StartOfTheMonth.DayOfWeek.ToString("d")) + 2;
            for (int i = 1; i < DaysOfTheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                calendar.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.DAys(i);
                calendar.Controls.Add(ucdays);
                ucdays.Click += (s, e1) =>
                {
                    UserControlDays b = s as UserControlDays;
                    addHours(Convert.ToInt32(b.DAys2()), $"{b.DAys2()}/{month}/{year}", month, year);
                };
            }
        }

        private void hours_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            calendar.Controls.Clear();
            month++;
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthName + " " + year;
            DateTime StartOfTheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
          
            int DaysOfTheWeek = Convert.ToInt32(StartOfTheMonth.DayOfWeek.ToString("d")) + 2;
            for (int i = 1; i < DaysOfTheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                calendar.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.DAys(i);
                calendar.Controls.Add(ucdays);
                ucdays.Click += (s, e1) =>
                {
                    UserControlDays b = s as UserControlDays;
                    addHours(Convert.ToInt32(b.DAys2()), $"{b.DAys2()}/{month}/{year}", month, year);
                };
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            calendar.Controls.Clear();
            month--;
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            LBDATE.Text = monthName + " " + year;
            DateTime StartOfTheMonth = new DateTime(year, month, 1);
            int days = DateTime.DaysInMonth(year, month);
            int DaysOfTheWeek = Convert.ToInt32(StartOfTheMonth.DayOfWeek.ToString("d")) + 2;
            for (int i = 1; i < DaysOfTheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                calendar.Controls.Add(ucblank);
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.DAys(i);
                calendar.Controls.Add(ucdays);
                ucdays.Click += (s, e1) =>
                {
                    UserControlDays b = s as UserControlDays;
                    addHours(Convert.ToInt32(b.DAys2()), $"{b.DAys2()}/{month}/{year}", month, year);
                };
            }
        }
        SqlDataReader reader, rea;
        private void addHours(int num, string date,int month,int year)
        {
            hours.Controls.Clear();
            reader = DBClass.ExcuteReader("select * from hoursTable where numDay = " + num);

            while (reader.Read())
            {
                if (StudNum == 1)
                {
                     result = (bool)DBClass.ExcuteScalar(" select case when exists(select * from reg1 where time ='"
                  + reader[2].ToString()
                  + "' and date = '"
                  + date + "') then CAST( 1 as BIT) else CAST(0 as BIT)end as exp");

                }
                else if(StudNum == 2)
                {
                    result = (bool)DBClass.ExcuteScalar(" select case when exists(select * from reg2 where time ='"
               + reader[2].ToString()
               + "' and date = '"
               + date + "') then CAST( 1 as BIT) else CAST(0 as BIT)end as exp");
                }
                else
                {
                    result = (bool)DBClass.ExcuteScalar(" select case when exists(select * from reg3 where time ='"
               + reader[2].ToString()
               + "' and date = '"
               + date + "') then CAST( 1 as BIT) else CAST(0 as BIT)end as exp");
                }

                if (result)
                {
                    hourControl2 hourControl = new hourControl2();
                    hourControl.BackColor = Color.Green;
                    hourControl.ForeColor = Color.White;
                    hourControl.Hours(reader[3].ToString(), reader[2].ToString());
                    hours.Controls.Add(hourControl);
                }
                else
                {

                    hourControl2 hourControl = new hourControl2();
                            hourControl.Hours(reader[3].ToString(),reader[2].ToString());
                            hours.Controls.Add(hourControl);
                            hourControl.Click += (s, e1) =>
                            {
                                hourControl2 b = s as hourControl2;
                                num1 = date;
                                range = b.label11();
                                hour = b.label22();
                                this.panel1.Controls.Clear();
                                official_booking formMain = new official_booking(num1, hour, range, month,year,num, StudNum) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                                 formMain.FormBorderStyle = FormBorderStyle.None;
                                this.panel1.Controls.Add(formMain);
                                formMain.Show();

                            };

                }

                }            
           

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            Home formMain = new Home() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formMain.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(formMain);
            formMain.Show();
        }
        
        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int Day = Convert.ToInt32(DateTime.Now.Day.ToString());
            int Month = Convert.ToInt32(DateTime.Now.Month.ToString());
            int timeOfToDay =Convert.ToInt32( DateTime.Now.ToString("HH"));
            DBClass.ExcuteNonQuery($"DELETE FROM reg1 WHERE  CONVERT(int, time) >{ timeOfToDay } AND num > {Day}  AND month > {Month}  ");
            DBClass.ExcuteNonQuery($"DELETE FROM reg2 WHERE  CONVERT(int, time) >{ timeOfToDay } AND num > {Day}  AND month > {Month}  ");
            DBClass.ExcuteNonQuery($"DELETE FROM reg3 WHERE  CONVERT(int, time) >{ timeOfToDay } AND num > {Day}  AND month > {Month}  ");

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      

    }
}

//    SqlDataReader dr2;
//    while (dr.Read())
//    {
//        SqlCommand cm2 = new SqlCommand();
//        cm2.Connection = conn;
//        cm2.CommandType = CommandType.Text;

//        cm2.CommandText = $" select case when exists(select* from reg1 where time ={dr[1]} and date = { date }) then CAST( 1 as BIT) else CAST(0 as BIT)end";
//        // dr.Close();
//        int var1 = Convert.ToInt32(dr[2]);
//        dr2 = cm2.ExecuteReader();


//        if (Convert.ToInt32(dr,dr2[0]) == 1)
//        {
//            hours.Controls.Clear();
//            hourControl2 hourControl = new hourControl2();
//            hourControl.BackColor = Color.Green;
//            hourControl.ForeColor = Color.White;
//            hourControl.Hours(var1);
//            hours.Controls.Add(hourControl);
//        }
//        else
//        {

//            hourControl2 hourControl = new hourControl2();
//            hourControl.Hours(var1);
//            hours.Controls.Add(hourControl);
//            hourControl.Click += (s, e1) =>
//            {
//                hourControl2 b = s as hourControl2;
//                num1 = date;
//                num2 = b.label();
//                //this.Hide();
//                //Fatima's Form ==
//                //  MainForm MainForm1 = new MainForm();
//                this.panel1.Controls.Clear();
//                // may be this way true i will sure!!!!
//                //(date,Convert.ToString( dr[1])
//                official_booking formMain = new official_booking(num1, num2) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
//                // Home formMain = new Home() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
//                formMain.FormBorderStyle = FormBorderStyle.None;
//                this.panel1.Controls.Add(formMain);
//                formMain.Show();

//                //official_booking offical_BookingForm1 = new official_booking();
//                //offical_BookingForm1.Show();
//                //};
//            }
//      dr2.Close();
//            cm2.Dispose();

//        }
//        conn.Dispose();

//        //foreach (int i in list)
//        //{
//        //    hours.Controls.Clear();
//        //    hourControl2 hourControl = new hourControl2();
//        //    hourControl.Hours(i.hour);
//        //    hours.Controls.Add(hourControl);

//        //}

//    } }
//catch (Exception ex)
//{
//    MessageBox.Show(ex.Message);
//}
//finally
//{ 

//}