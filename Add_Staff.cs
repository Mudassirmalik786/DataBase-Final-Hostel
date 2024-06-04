using DBG35FProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DBG20FinalProject
{
    public partial class Add_Staff : Form
    {
        public Add_Staff()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = "";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {


            /* if (newPass.Text != ConfirmPass.Text)
             {
                 MessageBox.Show("Passwords not matching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //IF PASSword do not match then wee will change colors
                 newPass.BackColor = Color.Red;
                 ConfirmPass.BackColor = Color.Red;
             }
             else
             {
                 // if it maches then change color
                 newPass.BackColor = SystemColors.Window;
                 ConfirmPass.BackColor = SystemColors.Window;
             }
             if (fName.Text == "" || lName.Text == "" || desg.Text == "" || cont.Text == "" || address.Text == "" || newPass.Text == "" || date.Text == "" || ConfirmPass.Text == "")
             {
                 MessageBox.Show("Enter the Details First!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             else if (cont.Text.Length != 11) { MessageBox.Show("Contact No Should be of 11 digit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
             else
             {
        //*******************PUTTING VALUES INTO PERSON TABLE************************
                 var con1 = Configuration.getInstance().getConnection();
                 SqlCommand cmd1 = new SqlCommand("INSERT INTO Person (FirstName, LastName, Contact, DOB, Address, Email, Password) VALUES (@FirstName, @LastName, @Contact, @DOB, @Address, @Email, @Password); SELECT SCOPE_IDENTITY();", con1);
                 cmd1.Parameters.AddWithValue("@FirstName", fName.Text);
                 cmd1.Parameters.AddWithValue("@LastName", lName.Text);
                 cmd1.Parameters.AddWithValue("@Contact", cont.Text);
                 cmd1.Parameters.AddWithValue("@DOB", DateTime.Parse(date.Text));
                 cmd1.Parameters.AddWithValue("@Address", address.Text);
                 cmd1.Parameters.AddWithValue("@Email", Email.Text);
                 cmd1.Parameters.AddWithValue("@Password", newPass.Text);

                 con1.Open();
                 int personID = Convert.ToInt32(cmd1.ExecuteScalar());
                 con1.Close();

      // **************Insert data into the Stafff table using the generated Person ID**********************
                 var con2 = Configuration.getInstance().getConnection();
                 SqlCommand cmd2 = new SqlCommand("INSERT INTO Staff (PersonID, Position, Salary) VALUES (@PersonID, @Position, @Salary)", con2);
                 cmd2.Parameters.AddWithValue("@PersonID", personID);
                 cmd2.Parameters.AddWithValue("@Position", desg.SelectedItem.ToString());
                 cmd2.Parameters.AddWithValue("@Salary", salaryy.SelectedText.ToString());

                 con2.Open();
                 cmd2.ExecuteNonQuery();
                 con2.Close();






                 MessageBox.Show("New Staff Registered Successfully!!!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                 ResetFields();
            */



            if (fName.Text == "" || lName.Text == "" || desg.Text == "" || cont.Text == "" || address.Text == "" || ConfirmPass.Text == "" || date.Text == "")
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
                cmd.Parameters.AddWithValue("@Password", ConfirmPass.Text);
                cmd.Parameters.AddWithValue("@DOB", DateTime.Parse(date.Text));
                cmd.Parameters.AddWithValue("@Contact", cont.Text);
                cmd.Parameters.AddWithValue("@Address", address.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Staff has been Added Successfully!!!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fName.Text = " ";
                lName.Text = " ";
                desg.Text = " ";
                cont.Text = " ";
                address.Text = " ";
                ConfirmPass.Text = " ";

            }




        }
        private void ResetFields()
        {
            fName.Text = "";
            lName.Text = "";
            desg.Text = "";
            address.Text = "";
            date.Text = "";
            newPass.Text = "";
            ConfirmPass.Text = "";
            cont.Text = "";
        }

        private void EXIT_BUTTON_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("exec stpGetAllStaff", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Table_SAdd.DataSource = dt;
        }

        private void ConfirmPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
