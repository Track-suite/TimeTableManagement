using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using WinFormsApp1.Thakshila;
using Ttable.Asram;


namespace WinFormsApp1
{
    
    public partial class Form2 : Form
    {
        //Database Connection-------------------
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-45UO70S;Initial Catalog=ITPM;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        //ID variable used i updating and deleting-------------------
        int id = 0;

        public Form2()
        {
            InitializeComponent();
            DisplayData();
            DisplayData1();
        }
        //Student form
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Table_Student", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

        }

        //generate id generate table
        private void DisplayData1()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Table_Generate", con);
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;

            con.Close();

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 add = new Form3();
            add.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSubjects add = new AddSubjects();
            add.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 add = new Form1();
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

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            LocationTimeTable add = new LocationTimeTable();
            add.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 add = new Form1();
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

        private void btnManageClear_Click(object sender, EventArgs e)
        {

        }

        private void lblGroupNum_Click(object sender, EventArgs e)
        {

        }

        private void btnManageUpdate_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update Table_Student set AcademicYearSemester=@academicyear,Programme=@programme,GroupNumber=@groupnumber,SubGroupNumber=@subgroupnumber where id=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@academicyear", txtacademic.Text);
            cmd.Parameters.AddWithValue("@programme", comboProgramme.Text);
            cmd.Parameters.AddWithValue("@groupnumber",numericgroup.Text);
            cmd.Parameters.AddWithValue("@subgroupnumber", numericsub.Text);



            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated Successfully");

            con.Close();
            DisplayData();

        }

        private void btnManageDelete_Click(object sender, EventArgs e)
        {
            
            if (id != 0)
            {

                cmd = new SqlCommand("delete Table_Student where id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                

            }

            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtacademic.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboProgramme.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            numericgroup.Text = (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            numericsub.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

        }

        private void txtSubId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGroupId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSub_Click(object sender, EventArgs e)
        {

        }

        private void lblGroup_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSubGroup_Click(object sender, EventArgs e)
        {

        }

        private void lblProgramme_Click(object sender, EventArgs e)
        {

        }

        private void lblAcademic_Click(object sender, EventArgs e)
        {

        }

        private void btnManageStudent_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtGroupId.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSubId.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            
        }

        private void btnSubIdDelete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete Table_Generate where id=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully!");



            DisplayData();
        }
    }
}
