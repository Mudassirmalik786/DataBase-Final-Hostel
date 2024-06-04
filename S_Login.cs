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

namespace DBG20FinalProject
{
    public partial class S_Login : Form
    {
        public S_Login()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.ControlBox = false;
        }

        private void S_Login_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            DialogResult dia;
            dia = MessageBox.Show("Do You want to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.Yes)
            {
                this.Hide();
                DashBoard db = new DashBoard();
                db.Show();
            }
            else
            {
                this.Show();
            }
        }

      

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }   

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.PasswordChar == '*')
            {
                button1.BringToFront();
                textBox1.PasswordChar = '\0';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.PasswordChar == '\0')
            {
                button2.BringToFront();
                textBox1.PasswordChar = '*';
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Enter login Details First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string connectionString = "Data Source=(Local);Initial Catalog=HostelFinal;Integrated Security=True;";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        con.Open(); 

                        string id = username.Text;
                        string pass = textBox1.Text.ToString();
                        string query = "SELECT StudentID, Password FROM Student WHERE StudentID = @Username AND Password = @Password";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Username", username.Text);
                            cmd.Parameters.AddWithValue("@Password", textBox1.Text);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    id = reader["StudentID"].ToString();
                                    pass = reader["Password"].ToString();
                                    this.Hide();
                                    Student st = new Student(id);
                                    st.Show();
                                }
                                else
                                {
                                    
                                    MessageBox.Show("Invalid Login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }



            }
        }

        private void EXIT_BUTTON_Click(object sender, EventArgs e)
        {
            DialogResult dia;
            dia = MessageBox.Show("Do You want to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dia == DialogResult.Yes)
            {
                this.Hide();
                NewDashboard db = new NewDashboard();
                db.Show();
            }

            // If the user chooses not to exit, do nothing (just close the message box)
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
