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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }


        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Enter login Details First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
            else if (username.Text != "admin" || textBox1.Text != "admin")
            {
                MessageBox.Show("Invalid login Details" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                admin ad = new admin();
                ad.Show();
            }
            
           
          
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            DialogResult dia;
            dia = MessageBox.Show("Do You want to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.Yes)
            {
                this.Hide();
                DashBoard db = new DashBoard();
                db.Show();
            }
            else
            {
                this.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void Show_Click_1(object sender, EventArgs e)
        {
            if(textBox1.PasswordChar == '*')
            {
                hide.BringToFront();
                textBox1.PasswordChar = '\0';
            }
        }

        private void hide_Click(object sender, EventArgs e)
        {
            if (textBox1.PasswordChar == '\0')
            {
                Show.BringToFront();
                textBox1.PasswordChar = '*'; 
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EXIT_BUTTON_Click(object sender, EventArgs e)
        {
            DialogResult dia;
            dia = MessageBox.Show("Do You want to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.Yes)
            {
                this.Hide();
                DashBoard db = new DashBoard();
                db.Show();
            }
            else
            {
                this.Show();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Enter login Details First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (username.Text != "admin" || textBox1.Text != "admin")
            {
                MessageBox.Show("Invalid login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                admin ad = new admin();
                ad.Show();
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Enter login Details First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (username.Text != "abdullah" || textBox1.Text != "12121212")
            {
                MessageBox.Show("Invalid login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (username.Text != "hamza" || textBox1.Text != "12345678")
            {
                MessageBox.Show("Invalid login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                admin ad = new admin();
                ad.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dia;
            dia = MessageBox.Show("Do You want to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.Yes)
            {
                this.Hide();
                NewDashboard db = new NewDashboard();
                db.Show();
            }
            else
            {
                this.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
