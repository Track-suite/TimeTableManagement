using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using WinFormsApp1.Thakshila;


namespace WinFormsApp1.Thakshila
{
    public partial class ViewParallel : Form
    {
        //Database connection
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-45UO70S;Initial Catalog=ITPM;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public ViewParallel()
        {
            InitializeComponent();
            DisplayData();
        }
        private void DisplayData()
        {

            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from ParallelSession1", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();


        }

        private void ViewParallel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ParallelSessioncs add = new ParallelSessioncs();
            add.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
