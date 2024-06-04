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
    public partial class S_Del : Form
    {
        public S_Del()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Staff member has been deleted Successfully!!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You!!", "Thanks", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void S_Del_Load(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand SqlComm = new SqlCommand("DELETE From Staff WHERE ID=@Id", con);
            SqlComm.Parameters.AddWithValue("@Id", comboBox1.Text);
            try
            {
                SqlComm.ExecuteNonQuery();
                MessageBox.Show("Staff has been Deleted Successfully!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboBox1.Text = "";
                id.Text = " ";
                fName.Text = " ";
                lName.Text = " ";
                desg.Text = " ";
                cont.Text = " ";
                address.Text = " ";
                pass.Text = " ";
                date.Text = " ";
          }
            catch (Exception )
            {
                MessageBox.Show("Erron on Deletiing Staff information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select ID, FirstName , LastName , Designation, Password, DOB, Contact, Address" +
                "                             From Staff" +
                "                             Where ID = @Id", con);

            cmd.Parameters.AddWithValue("@Id", comboBox1.Text);
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You!!", "Thanks", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand SqlComm = new SqlCommand("DELETE From Staff WHERE ID=@Id", con);
            SqlComm.Parameters.AddWithValue("@Id", comboBox1.Text);
            try
            {
                SqlComm.ExecuteNonQuery();
                MessageBox.Show("Staff has been Deleted Successfully!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboBox1.Text = "";
                id.Text = " ";
                fName.Text = " ";
                lName.Text = " ";
                desg.Text = " ";
                cont.Text = " ";
                address.Text = " ";
                pass.Text = " ";
                date.Text = " ";
            }
            catch (Exception)
            {
                MessageBox.Show("Erron on Deletiing Staff information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
