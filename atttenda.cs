using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBG20FinalProject
{
    public partial class atttenda : Form
    {
        public atttenda()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Attendancere aa = new Attendancere();
            aa.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentInfor st = new StudentInfor();

            st.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FoodRec fd = new FoodRec();
            fd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Billge bu = new Billge();
            bu.Show();
        }
    }
}
