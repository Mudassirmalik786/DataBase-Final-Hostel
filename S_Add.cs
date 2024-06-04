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
    public partial class S_Add : Form
    {
        public S_Add()
        {
            InitializeComponent();
        }
        private void ResetFields()
        {
            fName.Text = "";
            lName.Text = "";
            desg.Text = "";
            cont.Text = "";
            address.Text = "";
            pass.Text = "";
        }

        private void add_Click(object sender, EventArgs e)
        {
            if(fName.Text == "" || lName.Text == "" || desg.Text == "" || cont.Text == "" || address.Text == "" || pass.Text == "" || date.Text == "")
            {
                MessageBox.Show("Enter the Details First!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cont.Text.Length != 11) { MessageBox.Show("Contact No Should be of 11 digit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Insert into Staff values (@FirstName ,@LastName, @Designation ,@Password ,@DOB, @Contact, @Address)", con);
                cmd.Parameters.AddWithValue("@FirstName", fName.Text);
                cmd.Parameters.AddWithValue("@LastName", lName.Text);
                cmd.Parameters.AddWithValue("@Designation", desg.Text);
                cmd.Parameters.AddWithValue("@Password", pass.Text);
                cmd.Parameters.AddWithValue("@DOB", DateTime.Parse(date.Text));
                cmd.Parameters.AddWithValue("@Contact", cont.Text);
                cmd.Parameters.AddWithValue("@Address", address.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Staff has been Added Successfully!!!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                /* fName.Text = " ";
                 lName.Text = " ";
                 desg.Text = " ";
                 cont.Text = " ";
                 address.Text = " ";
                 pass.Text = " ";*/
                 ResetFields();


            }           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("exec stpGetAllStaff", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Table_SAdd.DataSource = dt;
        }

        private void Table_SAdd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            fName.Text = Table_SAdd.Rows[i].Cells[1].Value.ToString();
            lName.Text = Table_SAdd.Rows[i].Cells[2].Value.ToString();
            desg.Text = Table_SAdd.Rows[i].Cells[3].Value.ToString();
            pass.Text = Table_SAdd.Rows[i].Cells[4].Value.ToString();
            date.Text = Table_SAdd.Rows[i].Cells[5].Value.ToString();
            cont.Text = Table_SAdd.Rows[i].Cells[6].Value.ToString();
            address.Text = Table_SAdd.Rows[i].Cells[2].Value.ToString();
        }
    }
}
