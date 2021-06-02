using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Thakshila;
using Ttable.Asram;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        //Database connection
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-45UO70S;Initial Catalog=ITPM;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        //ID variable used in updating and deleting Record
        int id = 0;

        public Form3()
        {
            InitializeComponent();
            DisplayData();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnManageUpdate_Click(object sender, EventArgs e)
        {
            if (txtTag.Text != "" && txtTagCode.Text != "")
            {
                cmd = new SqlCommand("insert into Table_Tag1(TagName , TagCode) values(@tagname , @tagcode)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@tagname" , txtTag.Text);
                cmd.Parameters.AddWithValue("@tagcode", txtTagCode.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully!!!");
                DisplayData();
                ClearData();


            }

            else
            {
                MessageBox.Show("Please Provide Details!!");

            }
        }
            //Display Data in DataGridView
            private void DisplayData()
            {

                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select * from Table_Tag1", con);
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();


            }

            //Clear Data
            private void ClearData()
            {
                txtTag.Text = "";
                txtTagCode.Text = "";
                id = 0;
            }



        

        


        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 add = new Form1();
            add.Show();
        }

        private void btnUpdateTag_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update Table_Tag1 set TagName=@tagname,TagCode=@tagcode where id=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@tagname", txtTag.Text);
            cmd.Parameters.AddWithValue("@tagcode", txtTagCode.Text);
           

            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated Successfully");

            con.Close();
            DisplayData();
            ClearData();
        }

        private void btnTagClear_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteTag_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {

                cmd = new SqlCommand("delete Table_Tag1 where id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();

            }

            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void txtTag_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtTag.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTagCode.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTagCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTag_Click(object sender, EventArgs e)
        {

        }

        private void lblTagCode_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            LocationTimeTable add = new LocationTimeTable();
            add.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
           NotAvilableTime add = new NotAvilableTime();
            add.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void sidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddLocations add = new AddLocations();
            add.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
           AddSubjects add = new AddSubjects();
            add.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
           AddLectures add = new AddLectures();
            add.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            addWorkingDays add = new addWorkingDays();
            add.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Statistics add = new Statistics();
            add.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
