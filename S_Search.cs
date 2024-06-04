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
    public partial class S_Search : Form
    {
        public S_Search()
        {
            InitializeComponent();
        }

        private void S_Search_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select ID from Staff ", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {

                comboBox1.Items.Add(dr["Id"].ToString());


            }
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * From staff", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Enter the Id you want to Search!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Select ID, FirstName , LastName , Designation, Password, DOB, Contact, Address" +
               "                             From Staff" +
               "                             Where ID = @Id", con);
                cmd.Parameters.AddWithValue("@Id", comboBox1.Text);

                //Data will Go to the Table 
                SqlDataAdapter daa = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                daa.Fill(dt);
                dataGridView1.DataSource = dt;

                //Data Will go to the text boxes
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    id.Text = da.GetValue(0).ToString();
                    fName.Text = da.GetValue(1).ToString();
                    lName.Text = da.GetValue(2).ToString();
                    desg.Text = da.GetValue(3).ToString();
                    pass.Text = da.GetValue(4).ToString();
                    date.Text = da.GetValue(5).ToString();
                    cont.Text = da.GetValue(6).ToString();
                    address.Text = da.GetValue(7).ToString();

                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var con = Configuration.getInstance().getConnection();
            //SqlCommand cmd = new SqlCommand("Select ID, FirstName , LastName , Designation, Password, DOB, Contact, Address" +
            //    "                             From Staff" +
            //    "                             Where ID = @Id", con);

            //cmd.Parameters.AddWithValue("@Id", comboBox1.Text);
            //SqlDataReader da = cmd.ExecuteReader();
            //while (da.Read())
            //{
            //    id.Text = da.GetValue(0).ToString();
            //    fName.Text = da.GetValue(1).ToString();
            //    lName.Text = da.GetValue(2).ToString();
            //    desg.Text = da.GetValue(3).ToString();
            //    pass.Text = da.GetValue(4).ToString();
            //    date.Text = da.GetValue(5).ToString();
            //    cont.Text = da.GetValue(6).ToString();
            //    address.Text = da.GetValue(7).ToString();

            //}
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            comboBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            id.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            fName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            lName.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            desg.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            pass.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            date.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            cont.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            address.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * From staff", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Enter the Id you want to Search!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Select ID, FirstName , LastName , Designation, Password, DOB, Contact, Address" +
               "                             From Staff" +
               "                             Where ID = @Id", con);
                cmd.Parameters.AddWithValue("@Id", comboBox1.Text);

                //Data will Go to the Table 
                SqlDataAdapter daa = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                daa.Fill(dt);
                dataGridView1.DataSource = dt;

                //Data Will go to the text boxes
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    id.Text = da.GetValue(0).ToString();
                    fName.Text = da.GetValue(1).ToString();
                    lName.Text = da.GetValue(2).ToString();
                    desg.Text = da.GetValue(3).ToString();
                    pass.Text = da.GetValue(4).ToString();
                    date.Text = da.GetValue(5).ToString();
                    cont.Text = da.GetValue(6).ToString();
                    address.Text = da.GetValue(7).ToString();

                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
