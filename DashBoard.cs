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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            //Panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            S_Login st = new S_Login();
            st.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            St_Login sf = new St_Login();
            sf.Show();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            
        }

        

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            /*DialogResult dia;
            dia = MessageBox.Show("Do You want to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }*/

          
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel2.Visible = true;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            
            Panel1.Visible = false;
            Panel2.Visible = false;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel2.Visible = true;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            Panel3.Visible = true;
           // Panel4.Visible = true;
        }

        private void DashBoard_MouseLeave(object sender, EventArgs e)
        {
            Panel3.Visible = false;
           // Panel4.Visible = false;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel6.Visible = true;

        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel6.Visible = false;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
