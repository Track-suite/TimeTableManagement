using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1.Thakshila
{
    public partial class ViewNonoverlapping : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-45UO70S;Initial Catalog=ITPM;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public ViewNonoverlapping()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {

            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from NonoverlappingSession", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();


        }

        private void ViewNonoverlapping_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NonOverlapping add = new NonOverlapping();
            add.Show();
        }
    }
}
