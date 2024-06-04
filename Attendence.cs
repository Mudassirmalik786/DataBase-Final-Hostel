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
    public partial class Attendence : Form
    {
        public Attendence()
        {
            InitializeComponent();
        }

        private void Attendence_Load(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Code to Search Attendence
        private void add_Click(object sender, EventArgs e)
        {
            if (comboBox5.Text == "")
            {
                MessageBox.Show("Enter the Id you want to Search!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Select *" +
               "                             From Attendance" +
               "                             Where AttendanceID = @Id", con);
                cmd.Parameters.AddWithValue("@Id", comboBox5.Text);

                //Data will Go to the Table 
                SqlDataAdapter daa = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                daa.Fill(dt);
                dataGridView1.DataSource = dt;

            }
        }



        // Code to Load Student ID's
        private void s_Load_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select StudentID from Student ", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["StudentID"].ToString());
            }
        }

        // Code to Load Staff ID's
        private void st_Load_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select ID from Staff ", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox2.Items.Add(dr["ID"].ToString());
            }
        }

        // Code to Load Food ID's
        private void f_Load_Click(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select FoodID from food ", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox3.Items.Add(dr["FoodID"].ToString());
            }
        }

        // Code to View Attendence 
        private void view_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * From Attendance", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        //Code For adding the Attendence
        private void add_Click_1(object sender, EventArgs e)
        {
           if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || att.Text == "" || guest.Text == "" || date.Text == "")

{
    MessageBox.Show("Enter the Details First!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
else
{
    var con = Configuration.getInstance().getConnection();
    SqlTransaction transaction = con.BeginTransaction();
    try
    {
        int lastId, total;
        int t_att, attendence, guests;
        String id = comboBox3.Text.ToString();
        attendence = int.Parse(att.Text);
        guests = int.Parse(guest.Text);

        // Calculate total attendance
        t_att = attendence + guests;

        // Retrieve cost per dish
        string costQuery = "SELECT CostPerDish FROM Food WHERE FoodID = @FoodID";
        SqlCommand command = new SqlCommand(costQuery, con, transaction);
        command.Parameters.AddWithValue("@FoodID", int.Parse(comboBox3.Text));
        object result = command.ExecuteScalar();
        if (result != null &&  result!= DBNull.Value)
        {
           string result1=result.ToString();
            int costPerDish = int.Parse(result1);
            total = costPerDish * t_att;

        // Insert attendance record
        string insertQuery = "INSERT INTO Attendance (StudentID, StaffID, FoodID, Attendence, Guest, Total_Attendence, Date) " +
                             "VALUES (@StudentID, @StaffID, @FoodID, @Attendence, @Guest, @Total_Attendence, @Date);" +
                             "SELECT SCOPE_IDENTITY();"; // Retrieve last inserted ID
        command.CommandText = insertQuery;
        command.Parameters.Clear();
        command.Parameters.AddWithValue("@StudentID", int.Parse(comboBox1.Text));
        command.Parameters.AddWithValue("@StaffID", int.Parse(comboBox2.Text));
        command.Parameters.AddWithValue("@FoodID", int.Parse(comboBox3.Text));
        command.Parameters.AddWithValue("@Attendence", int.Parse(att.Text));
        command.Parameters.AddWithValue("@Guest", int.Parse(guest.Text));
        command.Parameters.AddWithValue("@Total_Attendence", t_att);
        command.Parameters.AddWithValue("@Date", DateTime.Parse(date.Text));
         lastId= Convert.ToInt32(command.ExecuteScalar()); // Retrieve last inserted ID
        }
        else
        {
            Console.WriteLine("No such Food Item.");
            return;
        }
        // Update total price
        string updateQuery = "UPDATE Attendance SET Total_Price = @TotalPrice WHERE AttendanceID = @AttendanceID";
        command.CommandText = updateQuery;
        command.Parameters.Clear();
        command.Parameters.AddWithValue("@TotalPrice", total);
        command.Parameters.AddWithValue("@AttendanceID", lastId);
        command.ExecuteNonQuery();

        transaction.Commit();
        MessageBox.Show("Attendance has been marked!!!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        transaction.Rollback();
    }
}

        }

        // Code to Load Attendence ID's
        private void button1_Click(object sender, EventArgs e)
        {
            comboBox5.Items.Clear();

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select AttendanceID from Attendance ", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox5.Items.Add(dr["AttendanceID"].ToString());
            }
        }

        // Code to Load Data from table to Boxes on cell Click
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            comboBox5.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            comboBox3.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            att.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            guest.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            date.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
        }

        // Code to Delete Attendence
        private void del_Click(object sender, EventArgs e)
        {
            if (comboBox5.Text == "")
            {
                MessageBox.Show("Enter the Attendence Id first!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand SqlComm = new SqlCommand("DELETE From Attendance WHERE AttendanceID=@Id", con);
                SqlComm.Parameters.AddWithValue("@Id", comboBox5.Text);
                try
                {
                    SqlComm.ExecuteNonQuery();
                    MessageBox.Show("Attendence has been Deleted Successfully!!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    comboBox5.Text = " ";
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // Code to Update Attendence
        private void update_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();

            int t_att, attendence, guests;
            String id = comboBox3.Text.ToString();

            attendence = int.Parse(att.Text);
            guests = int.Parse(guest.Text);

            //Total Attendence 
            t_att = attendence + guests;

            //Query For getting the CostperDish 
            string cost = ("Select CostPerDish From Food where FoodID = '" + comboBox3.Text + "'  ").ToString();
            SqlDataAdapter da = new SqlDataAdapter(cost, con);
            DataTable dt = new DataTable();
            da.Fill(dt);


            if (dt.Rows.Count > 0)
            {
                id = comboBox3.Text;
                int t = int.Parse(dt.Rows[0].ItemArray[0].ToString());
                int total = t * t_att;

                SqlCommand cmd = new SqlCommand("Update Attendance set StudentID=@StudentID , StaffID=@StaffID, FoodID =@FoodID , Attendence=@Attendence ,Guest=@Guest, Total_Attendence=@Total_Attendence , Total_Price=@Total_Price , Date = @Date where AttendanceID=@Id", con);
                cmd.Parameters.AddWithValue("@Id", int.Parse(comboBox5.Text));
                cmd.Parameters.AddWithValue("@StudentID", int.Parse(comboBox1.Text));
                cmd.Parameters.AddWithValue("@StaffID", int.Parse(comboBox2.Text));
                cmd.Parameters.AddWithValue("@FoodID", int.Parse(comboBox3.Text));
                cmd.Parameters.AddWithValue("@Attendence", int.Parse(att.Text));
                cmd.Parameters.AddWithValue("@Guest", int.Parse(guest.Text));
                cmd.Parameters.AddWithValue("@Total_Attendence", t_att);
                cmd.Parameters.AddWithValue("@Total_Price", total);
                cmd.Parameters.AddWithValue("@Date", DateTime.Parse(date.Text));
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendence has been Updated!!!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    comboBox1.Text = " ";
                    comboBox2.Text = " ";
                    comboBox3.Text = " ";
                    comboBox5.Text = " ";
                    att.Text = " ";
                    guest.Text = " ";

                }
                catch (Exception)
                {
                    MessageBox.Show("Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
