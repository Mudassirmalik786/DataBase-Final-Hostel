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
    public partial class S_Bill : Form
    {
        public string Id { get; set; }
        public S_Bill(string ID)
        {
            ID = Id;
            InitializeComponent();
        }

        private void S_Bill_Load(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection(); SqlCommand cmd = new SqlCommand("Select * From Bill ", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
