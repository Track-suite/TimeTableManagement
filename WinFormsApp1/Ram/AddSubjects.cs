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
    public partial class AddSubjects : Form
    {
        FormManage fm = null;
        public AddSubjects()
        {
            InitializeComponent();
        }

        public AddSubjects(FormManage f)
        {
            InitializeComponent();
            this.fm = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           addWorkingDays add = new addWorkingDays();
            add.Show();
        }

        private void FormStatic_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
          Statistics add = new Statistics();
            add.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
           NotAvilableTime add = new NotAvilableTime();
            add.Show();
        }

        private void ViewSubbutton_Click(object sender, EventArgs e)
        {
            if (fm == null || fm.IsDisposed)
            {
                fm = new FormManage();
            }
            fm.Show();
            this.Hide();
        }

        private void SaveLecbutton_Click(object sender, EventArgs e)
        {
            //Database connection
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-45UO70S;Initial Catalog=ITPM;Integrated Security=True");
            SqlCommand cmd;

            string RoomType = "";
            if (radioButton1.Checked)
                RoomType = "1st Semester";
            else
                RoomType = "2nd Semester";


            cmd = new SqlCommand("Insert into subject(SubjectCode,SubjectName,OfferdYear,OfferedSemester,LectureHours,TutorialHours,LabHours,EvaluationHours)  values(@SubjectCode,@SubjectName,@OfferdYear,@OfferedSemester,@LectureHours,@TutorialHours,@LabHours,@EvaluationHours)", con);
            con.Open();
            
            cmd.Parameters.AddWithValue("@SubjectCode", SubCodetextBox.Text.ToString());
            cmd.Parameters.AddWithValue("@SubjectName", SubjecttextBox.Text.ToString());
            cmd.Parameters.AddWithValue("@OfferdYear", OfferedcomboBox.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@OfferedSemester", RoomType);
            cmd.Parameters.AddWithValue("@LectureHours", numericUpDown1.Text.ToString());
            cmd.Parameters.AddWithValue("@TutorialHours", numericUpDown2.Text.ToString());
            cmd.Parameters.AddWithValue("@LabHours", numericUpDown3.Text.ToString());
            cmd.Parameters.AddWithValue("@EvaluationHours", numericUpDown4.Text.ToString());
           

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully");
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

        private void button7_Click(object sender, EventArgs e)
        {

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
