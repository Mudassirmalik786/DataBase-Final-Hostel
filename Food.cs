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
    public partial class Food : Form
    {
        public Food()
        {
            InitializeComponent();
        }

        private void Food_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || comboBox2.Text == "" || comboBox3.Text == "")
            {
                MessageBox.Show("Please Enter the Details First!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Insert into Food values (@DishName ,@CostPerDish, @TotalDishes ,@Day ,@Shift, @SalePerDish)", con);
                cmd.Parameters.AddWithValue("@DishName", textBox1.Text);
                cmd.Parameters.AddWithValue("@CostPerDish", textBox4.Text);
                cmd.Parameters.AddWithValue("@TotalDishes", textBox2.Text);
                cmd.Parameters.AddWithValue("@Day", comboBox2.Text);
                cmd.Parameters.AddWithValue("@Shift", comboBox3.Text);
                cmd.Parameters.AddWithValue("@SalePerDish", textBox3.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Food has been added Successfully!!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
            }
        }

        private void view_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection(); SqlCommand cmd = new SqlCommand("Select * From Food", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void load_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select FoodID from Food ", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {

                comboBox1.Items.Add(dr["FoodID"].ToString());


            }
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
                "                             From Food" +
                "                             Where FoodID = @Id", con);
                cmd.Parameters.AddWithValue("@Id", comboBox1.Text);

                //Data Will Shown in Table
                SqlDataAdapter daa = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                daa.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand SqlComm = new SqlCommand("DELETE From Food WHERE FoodID=@Id", con);
            SqlComm.Parameters.AddWithValue("@Id", comboBox1.Text);
            try
            {
                SqlComm.ExecuteNonQuery();
                MessageBox.Show("Food has been Deleted Successfully!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboBox1.Text = "";
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
                textBox4.Text = " ";
                comboBox2.Text = " ";
                comboBox3.Text = " ";
            }
            catch (Exception)
            {
                MessageBox.Show("Erron on Deletiing Food information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int i = e.RowIndex;
            //comboBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            //textBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            //textBox4.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            //textBox2.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            //comboBox2.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            //comboBox3.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            //textBox3.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Please Enter the Details First!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Update Food set DishName = @DishName ,CostPerDish = @CostPerDish, TotalDishes = @TotalDishes ,Day = @Day ,Shift = @Shift, SalePerDish = @SalePerDish where FoodID = @Id", con);
                cmd.Parameters.AddWithValue("@Id", comboBox1.Text);
                cmd.Parameters.AddWithValue("@DishName", textBox1.Text);
                cmd.Parameters.AddWithValue("@CostPerDish", textBox4.Text);
                cmd.Parameters.AddWithValue("@TotalDishes", textBox2.Text);
                cmd.Parameters.AddWithValue("@Day", comboBox2.Text);
                cmd.Parameters.AddWithValue("@Shift", comboBox3.Text);
                cmd.Parameters.AddWithValue("@SalePerDish", textBox3.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Food has been added Successfully!!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select FoodID, DishName ,CostPerDish, TotalDishes ,Day ,Shift, SalePerDish" +
                "                             From Food" +
                "                             Where FoodID = @Id", con);

            cmd.Parameters.AddWithValue("@Id", comboBox1.Text);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {

                textBox1.Text = da.GetValue(1).ToString();
                textBox4.Text = da.GetValue(2).ToString();
                textBox2.Text = da.GetValue(3).ToString();
                comboBox2.Text = da.GetValue(4).ToString();
                comboBox3.Text = da.GetValue(5).ToString();
                textBox3.Text = da.GetValue(6).ToString();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || comboBox2.Text == "" || comboBox3.Text == "")
            {
                MessageBox.Show("Please Enter the Details First!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Insert into Food values (@DishName ,@CostPerDish, @TotalDishes ,@Day ,@Shift, @SalePerDish)", con);
                cmd.Parameters.AddWithValue("@DishName", textBox1.Text);
                cmd.Parameters.AddWithValue("@CostPerDish", textBox4.Text);
                cmd.Parameters.AddWithValue("@TotalDishes", textBox2.Text);
                cmd.Parameters.AddWithValue("@Day", comboBox2.Text);
                cmd.Parameters.AddWithValue("@Shift", comboBox3.Text);
                cmd.Parameters.AddWithValue("@SalePerDish", textBox3.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Food has been added Successfully!!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
            }
        }

        private void del_Click_1(object sender, EventArgs e)
        {
            del.Hide();
            var con = Configuration.getInstance().getConnection();
            SqlCommand SqlComm = new SqlCommand("DELETE From Food WHERE FoodID=@Id", con);
            SqlComm.Parameters.AddWithValue("@Id", comboBox1.Text);
            try
            {
                SqlComm.ExecuteNonQuery();
                MessageBox.Show("Food has been Deleted Successfully!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboBox1.Text = "";
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
                textBox4.Text = " ";
                comboBox2.Text = " ";
                comboBox3.Text = " ";
            }
            catch (Exception)
            {
                MessageBox.Show("Erron on Deletiing Food information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
