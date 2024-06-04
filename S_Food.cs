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
using DBG35FProject;

namespace DBG20FinalProject
{
    public partial class S_Food : Form
    {
        public S_Food()
        {
            InitializeComponent();
        }

      

        private void S_Food_Load(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * From Food", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomRadioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

            if (GetSelectedDayOfWeek() == "" || GetSelectedShift() == "")
            {
                MessageBox.Show("Select the DAY and MEAL first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Food WHERE Day = @day AND Shift = @shift", con);
            cmd.Parameters.AddWithValue("@day", GetSelectedDayOfWeek());
            cmd.Parameters.AddWithValue("@shift", GetSelectedShift());
            
            try
            {
                con.Open();
                //Data Will Shown in Table
                SqlDataAdapter daa = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                daa.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private string GetSelectedDayOfWeek()
        {
            string selectedDay = "";

            // Check each radio button to find the selected day
            if (monday.Checked)
                selectedDay = "Monday";
            else if (tues.Checked)
                selectedDay = "Tuesday";
            else if (wed.Checked)
                selectedDay = "Wednesday";
            else if (thurs.Checked)
                selectedDay = "Thursday";
            else if (fri.Checked)
                selectedDay = "Friday";
            else if (sat.Checked)
                selectedDay = "Saturday";
            else if (sun.Checked)
                selectedDay = "Sunday";

            return selectedDay;
        }

        private string GetSelectedShift()
        {
            string selectedShift = "";

            // Check if day shift or night shift is selected
             if (breakfast.Checked && dinner.Checked)
                MessageBox.Show("Check One MEAL TIME to View", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (breakfast.Checked && !dinner.Checked)
                //day shift = 0 ,     breakfast = 0
                selectedShift = "Day";

            else if (!breakfast.Checked && dinner.Checked)
                //night shift = 1..    ... dinner
                selectedShift = "Night";
            return selectedShift;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult dia;
            dia = MessageBox.Show("Do You want to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.Yes)
            {
                Application.Exit();
            }
    
        }

        private void monday_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
