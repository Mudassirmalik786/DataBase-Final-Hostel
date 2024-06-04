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
    public partial class admin : Form
    {
        private bool isCollapesd;
        public admin()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

       
        //Drop Down Code for Student Options 
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapesd)
            {

                DropDown.Height += 10;
                if (DropDown.Size == DropDown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapesd = false;
                }
            }
            else
            {
                DropDown.Height -= 10;
                if (DropDown.Size == DropDown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapesd = true;
                }
            }
        }

        //Drop Down Code For Staff Options
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapesd)
            {

                DropDown2.Height += 10;
                if (DropDown2.Size == DropDown2.MaximumSize)
                {
                    timer2.Stop();
                    isCollapesd = false;
                }
            }
            else
            {
                DropDown2.Height -= 10;
                if (DropDown2.Size == DropDown2.MinimumSize)
                {
                    timer2.Stop();
                    isCollapesd = true;
                }
            }
        }


        private void admin_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
            flowLayoutPanel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void student_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            View va = new View() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel2.Controls.Add(va);
            va.Show();
        }

        private void staff_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void add_Click_1(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            StdForm sf = new StdForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel2.Controls.Add(sf);
            sf.Show();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            Delete del = new Delete() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel2.Controls.Add(del);
            del.Show();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            Update up = new Update() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel2.Controls.Add(up);
            up.Show();
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            Search se = new Search() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel2.Controls.Add(se);
            se.Show();
        }

        private void S_Add_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            Add_Staff sa = new Add_Staff() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel2.Controls.Add(sa);
            sa.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void S_Del_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            S_Del sa = new S_Del() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel2.Controls.Add(sa);
            sa.Show();
        }

        private void S_Update_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            S_Update sa = new S_Update() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel2.Controls.Add(sa);
            sa.Show();
        }

        private void S_Search_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            S_Search sa = new S_Search() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel2.Controls.Add(sa);
            sa.Show();
        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
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
       
    }
}
