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
    public partial class hourControl2 : UserControl
    {
        public hourControl2()
        {
            InitializeComponent();
        }

        private void hourControl2_Load(object sender, EventArgs e)
        {

        }
        public void Hours(object range,string hour )
        {
            label1.Text = Convert.ToString(range) + "";
            label2.Text = Convert.ToString(hour);

        }
        public string label11()
        {
            return label1.Text;
        }
        public string label22()
        {
            return label2.Text;
        }
    }
}
