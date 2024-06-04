using DBG20FinalProject.Properties;
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
    public partial class NewDashboard : Form
    {
        public NewDashboard()
        {
            InitializeComponent();
            guna2Button1.BorderRadius = 10;
            guna2Button2.BorderRadius = 10;
            guna2Button3.BorderRadius = 10;
            // this.MinimumSize = this.Size;
            //this.MaximumSize = this.Size;
            this.ControlBox = false;
            this.Text = "";



        }
      

        private void NewDashboard_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void PBgif_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            S_Login st = new S_Login();
            st.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            St_Login sf = new St_Login();
            sf.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DialogResult dia;
            dia = MessageBox.Show("Do You want to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
