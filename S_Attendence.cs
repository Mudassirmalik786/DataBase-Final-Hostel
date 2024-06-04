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
    public partial class S_Attendence : Form
    {
        public string Id { get; set; }
        public S_Attendence(string id)
        {
            Id = id;
            InitializeComponent();
        }   

        private void View_Click(object sender, EventArgs e)
        {
            if (date.Text == "")
            {
                MessageBox.Show("Enter the Date First!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Select *" +
                "                             From Attendance" +
                "                             Where Date = @date AND [StudentID] = '" + Id + "' ", con);
                cmd.Parameters.AddWithValue("@date", DateTime.Parse(date.Text));

                //Data Will Shown in Table
                SqlDataAdapter daa = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                daa.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void S_Attendence_Load_1(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * From Attendance where [StudentID] = '" + Id + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (date.Text == "")
            {
                MessageBox.Show("Enter the Date First!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Select *" +
                "                             From Attendance" +
                "                             Where Date = @date AND [StudentID] = '" + Id + "' ", con);
                cmd.Parameters.AddWithValue("@date", DateTime.Parse(date.Text));

                //Data Will Shown in Table
                SqlDataAdapter daa = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                daa.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
