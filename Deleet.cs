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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Delete_Load(object sender, EventArgs e)
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
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Enter the Student Id first!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var con = Configuration.getInstance().getConnection(); SqlCommand SqlComm = new SqlCommand("DELETE From Student WHERE StudentID=@Id", con);
                SqlComm.Parameters.AddWithValue("@Id", comboBox1.Text);
                try
                {
                    SqlComm.ExecuteNonQuery();
                    MessageBox.Show("Student has been Deleted Successfully!!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    fName.Text = "";
                    lName.Text = "";
                    reg_no.Text = "";
                    pass.Text = "";
                    date.Text = "";
                    contact.Text = "";
                    address.Text = "";
                    room.Text = "";
                    id.Text = "";

                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You!!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select FirstName , LastName , RegistrationNo, Password, DOB, Contact, Address, RoomNo, StudentID" +
                "                             From Student" +
                "                             Where StudentID = @Id", con);
            cmd.Parameters.AddWithValue("@Id", comboBox1.Text);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {   

                fName.Text = da.GetValue(0).ToString();
                lName.Text = da.GetValue(1).ToString();
                reg_no.Text = da.GetValue(2).ToString();
                pass.Text = da.GetValue(3).ToString();
                date.Text = da.GetValue(4).ToString();
                contact.Text = da.GetValue(5).ToString();
                address.Text = da.GetValue(6).ToString();
                room.Text = da.GetValue(7).ToString();
                id.Text = da.GetValue(8).ToString();

            }

        }
    }
}
