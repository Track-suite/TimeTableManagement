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
    public partial class ManageLectures : Form
    {
        AddSubjects s1 = null;
        int dataId;
        public ManageLectures()
        {
           // People = GetPeople();
            InitializeComponent();
            var select = "SELECT * FROM lecture";
            var c = new SqlConnection("Server = localhost\\SQLEXPRESS01; Database = IT19119618; Integrated Security = True;"); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
        }

       


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // var People = this.People;
           // dataGridView1.DataSource = People;
        }

        private void manageLocation_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelManage_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonManageDelete_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonManageUpdate_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection("Server = localhost\\SQLEXPRESS01; Database = IT19119618; Integrated Security = True;");
            SqlCommand cmd;


            cmd = new SqlCommand("update  lecture  set Employeeid=@Employeeid,LectureName=@LectureName,faculty=@faculty,Department=@Department,Center=@Center,Building=@Building,Level=@Level,Rank=@Rank where id=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@Employeeid", textBoxRoom.Text.ToString());
            cmd.Parameters.AddWithValue("@LectureName", textBoxBuilding.Text.ToString());
            cmd.Parameters.AddWithValue("@faculty", comboBox1.Text.ToString());
            cmd.Parameters.AddWithValue("@Department", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Center", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@Building", comboBox4.Text.ToString());
            cmd.Parameters.AddWithValue("@Level", comboBox5.Text.ToString());
            cmd.Parameters.AddWithValue("@Rank", textBoxCapacity.Text.ToString());
            cmd.Parameters.AddWithValue("@id", dataId);

            cmd.ExecuteNonQuery();
            con.Close();
            
            MessageBox.Show("Update Successfully!!!");
            ManageLectures m1 = new ManageLectures();
            this.Hide();
            m1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (s1 == null || s1.IsDisposed)
            {
                s1 = new AddSubjects();
            }
            s1.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataId= Int16.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBoxBuilding.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxRoom.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxCapacity.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            
            comboBox1.SelectedText = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBox2.SelectedText = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBox3.SelectedText = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            comboBox4.SelectedText = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            comboBox5.SelectedText = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();


        }

        private void buttonManageDelete_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server = localhost\\SQLEXPRESS01; Database = IT19119618; Integrated Security = True;");
            SqlCommand cmd;


            cmd = new SqlCommand("delete from lecture where id=@id", con);
            con.Open();
            
            cmd.Parameters.AddWithValue("@id", dataId);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Deleted Successfully!!!");
            ManageLectures m1 = new ManageLectures();
            this.Hide();
            m1.Show();
        }

        private void buttonManangeClear_Click(object sender, EventArgs e)
        {
            textBoxBuilding.Text ="";
            textBoxRoom.Text = "";
            textBoxCapacity.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           addWorkingDays add = new addWorkingDays();
            add.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddLectures add = new AddLectures();
            add.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 add = new Form1();
            add.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 add = new Form3();
            add.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddLocations add = new AddLocations();
            add.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            NotAvilableTime add = new NotAvilableTime();
            add.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Statistics add = new Statistics();
            add.Show();
        }

        private void button7_Click(object sender, EventArgs e)
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
