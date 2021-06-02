using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Thakshila;

namespace Ttable.Asram
{
    public partial class AddWorks : Form
    {
        //Database connection
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-45UO70S;Initial Catalog=ITPM;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        //ID variable used in Updating and Deleting Record  
        int ID = 0;
        public AddWorks()
        {
            InitializeComponent();
        }

        private void AddWorks_Load(object sender, EventArgs e)
        {

        }

        private void AddW_Click(object sender, EventArgs e)
        {
            String s = "";
            foreach (Control c in this.Controls)
            {

                if (c is CheckBox)
                {

                    CheckBox b = (CheckBox)c;
                    if (b.Checked)
                    {
                        s = b.Text + "," + s;
                    }
                }
            }
            cmd = new SqlCommand("Insert into AddWorks1 (NWorkDay,Days,Hours)  values(@nDays,@Days,@hours)", con);
            con.Open();
            cmd.Parameters.AddWithValue("nDays", NWorkday.Text);
            cmd.Parameters.AddWithValue("@Days", s);
            cmd.Parameters.AddWithValue("@hours", TimeP.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            LocationTimeTable add = new LocationTimeTable();
            add.Show();
        }
    }
}
