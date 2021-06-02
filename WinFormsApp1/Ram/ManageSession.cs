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
    public partial class ManageSession : Form
    {

        int dataId;
        public ManageSession()
        {
            InitializeComponent();
            
            var select = "SELECT * FROM session";
            var c = new SqlConnection("Server = localhost\\SQLEXPRESS01; Database = IT19119618; Integrated Security = True;"); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];


            var select4 = "SELECT * FROM location";
            var dataAdapter4 = new SqlDataAdapter(select4, c);

            var ds4 = new DataSet();
            dataAdapter4.Fill(ds4);
            for (int j = 0; j < ds4.Tables[0].Rows.Count; j++)
            {
                string text = ds4.Tables[0].Rows[j]["RoomName"].ToString();
                this.comboBox1.Items.Add(text);
            }
            //MessageBox.Show(ds.Tables[0].Rows[0]["LectureName"].ToString());
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonManageUpdate_Click(object sender, EventArgs e)
        {
            //Database connection
            SqlConnection con = new SqlConnection("Server = localhost\\SQLEXPRESS01; Database = IT19119618; Integrated Security = True;");
            SqlCommand cmd;


            cmd = new SqlCommand("update session set LectureName=@LectureName,TagName=@TagName,GroupID=@GroupID,SubjectName=@SubjectName,NoStudents=@NoStudents,Duration=@Duration,RoomName=@RoomName where id=@id", con);
            con.Open();

         
            cmd.Parameters.AddWithValue("@LectureName", comboBoxFaculty.Text.ToString());
            cmd.Parameters.AddWithValue("@TagName", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@GroupID", textBox5.Text.ToString());
            cmd.Parameters.AddWithValue("@SubjectName", textBox6.Text.ToString());
            cmd.Parameters.AddWithValue("@NoStudents", textBox7.Text.ToString());
            cmd.Parameters.AddWithValue("@Duration", textBox8.Text.ToString());
            cmd.Parameters.AddWithValue("@RoomName", comboBox1.Text.ToString());
            cmd.Parameters.AddWithValue("@id", dataId);

            cmd.ExecuteNonQuery();
            con.Close();
            ManageSession m1 = new ManageSession();
            this.Hide();
            m1.Show();
            MessageBox.Show("Record Updated Successfully");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataId = Int16.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            comboBoxFaculty.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            
            comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

        }

        private void buttonManageDelete_Click(object sender, EventArgs e)
        {
            //Database connection
            SqlConnection con = new SqlConnection("Server = localhost\\SQLEXPRESS01; Database = IT19119618; Integrated Security = True;");
            SqlCommand cmd;


            cmd = new SqlCommand("delete from session where id=@id", con);
            con.Open();

            
            cmd.Parameters.AddWithValue("@id", dataId);

            cmd.ExecuteNonQuery();
            con.Close();
            ManageSession m1 = new ManageSession();
            this.Hide();
            m1.Show();
            MessageBox.Show("Record Deleted Successfully");
        }

        private void buttonManangeClear_Click(object sender, EventArgs e)
        {
            comboBoxFaculty.Text = "";

            comboBox2.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
           addWorkingDays add = new addWorkingDays();
            add.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
           AddLectures add = new AddLectures();
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

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Statistics add = new Statistics();
            add.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
