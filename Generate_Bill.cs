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
    public partial class Generate_Bill : Form
    {
        public string Id { get; set; }

        public Generate_Bill()
        {
            Id = Id;
            InitializeComponent();
        }

        //Code to Load Students Id's
        private void s_Load_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select StudentID from Student ", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox2.Items.Add(dr["StudentID"].ToString());
            }
        }

        //Code to Load Attendence Id's
        private void b_Load_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select ID from Bill ", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["ID"].ToString());
            }
        }

        //Code to Add Bill 
        private void add_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "" || date.Text == "")
            {
                MessageBox.Show("Enter Studndet Id First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var con = Configuration.getInstance().getConnection();

                string ID = comboBox2.Text;

                String bill = "Select Sum(a.Total_Price) bill From Attendance as a Join Student as s on a.StudentID = s.StudentID where s.StudentID = '" + comboBox2.Text + "' Group by a.StudentID";
                String t_att = "Select Sum(a.Total_Attendence) bill From Attendance as a Join Student as s on a.StudentID = s.StudentID where s.StudentID = '" + comboBox2.Text + "' Group by a.StudentID";

                SqlDataAdapter da = new SqlDataAdapter(bill, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SqlDataAdapter daa = new SqlDataAdapter(t_att, con);
                DataTable dtt = new DataTable();
                daa.Fill(dtt);
                //da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    ID = comboBox2.Text;
                    int bills = int.Parse(dt.Rows[0].ItemArray[0].ToString());
                    int att = int.Parse(dtt.Rows[0].ItemArray[0].ToString());

                    SqlCommand cmd = new SqlCommand("Insert into Bill values (@StudentID , @Total_Attendances, @Bill , @Date)", con);
                    cmd.Parameters.AddWithValue("@StudentID", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@Total_Attendances", att);
                    cmd.Parameters.AddWithValue("@Bill", bills);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Parse(date.Text));
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Bill Generated", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        comboBox2.Text = " ";
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


        }

        private void Generate_Bill_Load(object sender, EventArgs e)
        {

        }

        private void view_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection(); SqlCommand cmd = new SqlCommand("Select * From Bill", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Enter the Id you want to Search!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Select *" +
               "                             From Bill" +
               "                             Where ID = @Id", con);
                cmd.Parameters.AddWithValue("@Id", comboBox1.Text);

                //Data will Go to the Table 
                SqlDataAdapter daa = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                daa.Fill(dt);
                dataGridView1.DataSource = dt;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void del_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Enter the Bill Id first!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand SqlComm = new SqlCommand("DELETE From Bill WHERE ID=@Id", con);
                SqlComm.Parameters.AddWithValue("@Id", comboBox1.Text);
                try
                {
                    SqlComm.ExecuteNonQuery();
                    MessageBox.Show("Bill has been Deleted Successfully!!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    comboBox1.Text = " ";
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
    }
}
