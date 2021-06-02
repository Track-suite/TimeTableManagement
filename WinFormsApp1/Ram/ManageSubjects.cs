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
    public partial class FormManage : Form
    {
        int dataId;
        public FormManage()
        {
            InitializeComponent();
            var select = "SELECT * FROM subject";
            var c = new SqlConnection("Server = localhost\\SQLEXPRESS01; Database = IT19119618; Integrated Security = True;"); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void buttonManageUpdate_Click(object sender, EventArgs e)
        {
            //Database connection
            SqlConnection con = new SqlConnection("Server = localhost\\SQLEXPRESS01; Database = IT19119618; Integrated Security = True;");
            SqlCommand cmd;

            string RoomType = "";
            if (radioButton1.Checked)
                RoomType = "1st Semester";
            else
                RoomType = "2nd Semester";


            cmd = new SqlCommand("update subject set SubjectCode=@SubjectCode,SubjectName=@SubjectName,OfferdYear=@OfferdYear,OfferedSemester=@OfferedSemester,LectureHours=@LectureHours,TutorialHours=@TutorialHours,LabHours=@LabHours,EvaluationHours=@EvaluationHours where id=@id", con);
            con.Open();

            cmd.Parameters.AddWithValue("@SubjectCode", textBox1.Text.ToString());
            cmd.Parameters.AddWithValue("@SubjectName", LecturetextBox.Text.ToString());
            cmd.Parameters.AddWithValue("@OfferdYear", FacultycomboBox.Text.ToString());
            cmd.Parameters.AddWithValue("@OfferedSemester", RoomType);
            cmd.Parameters.AddWithValue("@LectureHours", numericUpDown1.Text.ToString());
            cmd.Parameters.AddWithValue("@TutorialHours", numericUpDown2.Text.ToString());
            cmd.Parameters.AddWithValue("@LabHours", numericUpDown3.Text.ToString());
            cmd.Parameters.AddWithValue("@EvaluationHours", numericUpDown4.Text.ToString());
            cmd.Parameters.AddWithValue("@id", dataId);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully");

            FormManage m1 = new FormManage();
            this.Hide();
            m1.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataId = Int16.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            LecturetextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            numericUpDown1.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            numericUpDown2.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            numericUpDown3.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            numericUpDown4.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            String sem = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            if(sem == "1st Semester")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }

            FacultycomboBox.SelectedText = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            
        }

        private void buttonManageDelete_Click(object sender, EventArgs e)
        {
            //Database connection
            SqlConnection con = new SqlConnection("Server = localhost\\SQLEXPRESS01; Database = IT19119618; Integrated Security = True;");
            SqlCommand cmd;

           
            cmd = new SqlCommand("delete from subject where id=@id", con);
            con.Open();

            
            cmd.Parameters.AddWithValue("@id", dataId);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully");

            FormManage m1 = new FormManage();
            this.Hide();
            m1.Show();
        }

        private void buttonManangeClear_Click(object sender, EventArgs e)
        {

            LecturetextBox.Text = "";
            textBox1.Text = "";
            numericUpDown1.Text = "";
            numericUpDown2.Text = "";
            numericUpDown3.Text = "";
            numericUpDown4.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void panel2_Paint(object sender, PaintEventArgs e)
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
    }
}
