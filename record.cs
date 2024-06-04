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
    public partial class record : Form
    {
        public record()
        {
            InitializeComponent();
        }

        private void record_Load(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Enter the Bill Id first!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand SqlComm = new SqlCommand("DELETE From Record WHERE ID=@Id", con);
                SqlComm.Parameters.AddWithValue("@Id", comboBox1.Text);
                try
                {
                    SqlComm.ExecuteNonQuery();
                    MessageBox.Show("Reocrd has been Deleted Successfully!!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    comboBox1.Text = " ";
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void s_Load_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select FoodID from food ", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox2.Items.Add(dr["FoodID"].ToString());
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == ""  || sale.Text ==""  || dateTimePicker1.Text == "")
            {
                MessageBox.Show("Enter the Data First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var con = Configuration.getInstance().getConnection();
                string Id = comboBox2.Text;

                string dish = ("Select TotalDishes From Food where FoodID = '" + comboBox2.Text + "'  ").ToString();
                SqlDataAdapter da = new SqlDataAdapter(dish, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                string cost = ("Select CostPerDish From Food where FoodID = '" + comboBox2.Text + "'  ").ToString();
                SqlDataAdapter daa = new SqlDataAdapter(cost, con);
                DataTable dtt = new DataTable();
                daa.Fill(dtt);

                if (dt.Rows.Count > 0)
                {
                    Id = comboBox2.Text;

                    //cost 
                    int c = int.Parse(dtt.Rows[0].ItemArray[0].ToString());

                    //Total Dishes 
                    int t = int.Parse(dt.Rows[0].ItemArray[0].ToString());
                    int price1 = t * c;

                    //Sale Dishes
                    int s = int.Parse(sale.Text);
                    int price2 = s * c;

                    //Profit
                    int pro = price1 - price2;

                    SqlCommand cmd = new SqlCommand("Insert into Record values(@FoodId, @Profit , @Total_Dishes ,@Sale_Dishes , @Date )", con);
                    cmd.Parameters.AddWithValue("@FoodId", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@Profit", pro);
                    cmd.Parameters.AddWithValue("@Total_Dishes", t);
                    cmd.Parameters.AddWithValue("@Sale_Dishes", sale.Text);
                    cmd.Parameters.AddWithValue("Date", DateTime.Parse(dateTimePicker1.Text));
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record has been Successfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        comboBox2.Text = " ";
                        sale.Text = " ";
                        dateTimePicker1.Text = " ";
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Invalid Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

          
        }

        private void view_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * From Record", con);
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
               "                             From Record" +
               "                             Where ID = @Id", con);
                cmd.Parameters.AddWithValue("@Id", comboBox1.Text);

                //Data will Go to the Table 
                SqlDataAdapter daa = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                daa.Fill(dt);
                dataGridView1.DataSource = dt;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select ID from Record ", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["ID"].ToString());
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "" || sale.Text == "" || dateTimePicker1.Text == "")
            {
                MessageBox.Show("Enter the Data First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var con = Configuration.getInstance().getConnection();
                string Id = comboBox2.Text;

                string dish = ("Select TotalDishes From Food where FoodID = '" + comboBox2.Text + "'  ").ToString();
                SqlDataAdapter da = new SqlDataAdapter(dish, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                string cost = ("Select CostPerDish From Food where FoodID = '" + comboBox2.Text + "'  ").ToString();
                SqlDataAdapter daa = new SqlDataAdapter(cost, con);
                DataTable dtt = new DataTable();
                daa.Fill(dtt);

                if (dt.Rows.Count > 0)
                {
                    Id = comboBox2.Text;

                    //cost 
                    int c = int.Parse(dtt.Rows[0].ItemArray[0].ToString());

                    //Total Dishes 
                    int t = int.Parse(dt.Rows[0].ItemArray[0].ToString());
                    int price1 = t * c;

                    //Sale Dishes
                    int s = int.Parse(sale.Text);
                    int price2 = s * c;

                    //Profit
                    int pro = price1 - price2;

                    SqlCommand cmd = new SqlCommand("Update Record Set FoodId = @FoodId, Profit = @Profit , Total_Dishes = @Total_Dishes ,Sale_Dishes = @Sale_Dishes , Date = @Date WHere ID = @id", con);

                    cmd.Parameters.AddWithValue("@id", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@FoodId", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@Profit", pro);
                    cmd.Parameters.AddWithValue("@Total_Dishes", t);
                    cmd.Parameters.AddWithValue("@Sale_Dishes", sale.Text);
                    cmd.Parameters.AddWithValue("Date", DateTime.Parse(dateTimePicker1.Text));
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully Added");
                        comboBox1.Text = "";
                        comboBox2.Text = "";
                        dateTimePicker1.Text = "";
                        sale.Text = " ";

                    }
                    catch(Exception)
                    {
                        MessageBox.Show("Invalid Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            comboBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            sale.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            
        }
    }
}





