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
    public partial class AddSession : Form
    {
       
        public AddSession()
        {
            InitializeComponent();
            
            var c = new SqlConnection(@"Data Source=DESKTOP-45UO70S;Initial Catalog=ITPM;Integrated Security=True");
            var select = "SELECT * FROM lecture";
            var dataAdapter = new SqlDataAdapter(select, c);

            var ds = new DataSet();
            dataAdapter.Fill(ds);
            for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
            {
                string text = ds.Tables[0].Rows[j]["LectureName"].ToString() ;
                this.comboBoxFaculty.Items.Add(text);
            }

            var select1 = "SELECT * FROM Table_Tag1";
            var dataAdapter1 = new SqlDataAdapter(select1, c);

            var ds1 = new DataSet();
            dataAdapter1.Fill(ds1);
            for (int j = 0; j < ds1.Tables[0].Rows.Count; j++)
            {
                string text = ds1.Tables[0].Rows[j]["TagName"].ToString();
                this.comboBox1.Items.Add(text);
            }


            var select2 = "SELECT * FROM [dbo].[Subject]";
            var dataAdapter2 = new SqlDataAdapter(select2, c);

            var ds2 = new DataSet();
            dataAdapter2.Fill(ds2);
            for (int j = 0; j < ds2.Tables[0].Rows.Count; j++)
            {
                string text = ds2.Tables[0].Rows[j]["SubjectName"].ToString();
                this.comboBox2.Items.Add(text);
            }

            var select3 = "SELECT * FROM Table_Generate";
            var dataAdapter3 = new SqlDataAdapter(select3, c);

            var ds3 = new DataSet();
            dataAdapter3.Fill(ds3);
            for (int j = 0; j < ds3.Tables[0].Rows.Count; j++)
            {
                string text = ds3.Tables[0].Rows[j]["GroupId"].ToString();
                this.comboBox3.Items.Add(text);
            }


            var select4 = "SELECT * FROM location";
            var dataAdapter4 = new SqlDataAdapter(select4, c);

            var ds4 = new DataSet();
            dataAdapter4.Fill(ds4);
            for (int j = 0; j < ds4.Tables[0].Rows.Count; j++)
            {
                string text = ds4.Tables[0].Rows[j]["RoomName"].ToString();
                this.comboBox4.Items.Add(text);
            }
            //MessageBox.Show(ds.Tables[0].Rows[0]["LectureName"].ToString());

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelLocation_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {

        }

        private void button11_Click_2(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            //Database connection
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-45UO70S;Initial Catalog=ITPM;Integrated Security=True");
            SqlCommand cmd;


            cmd = new SqlCommand("Insert into session(LectureName,TagName,GroupID,SubjectName,NoStudents,Duration,RoomName,Day)  values(@LectureName,@TagName,@GroupID,@SubjectName,@NoStudents,@Duration,@RoomName,@day)", con);
            con.Open();

            
            cmd.Parameters.AddWithValue("@LectureName", textBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@TagName", comboBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@GroupID", comboBox3.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@SubjectName", comboBox2.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@NoStudents", textBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Duration", textBox1.Text.ToString());
            cmd.Parameters.AddWithValue("@RoomName", comboBox4.Text.ToString());
            cmd.Parameters.AddWithValue("@day", comboBox5.Text.ToString());

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ManageSession m = new ManageSession();
            this.Hide();
            m.Show();
        }

        private void comboBoxFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = comboBoxFaculty.Text.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddLectures a = new AddLectures();
            this.Hide();
            a.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            NotAvilableTime add = new NotAvilableTime();
            add.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            addWorkingDays add = new addWorkingDays();
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

        private void button9_Click(object sender, EventArgs e)
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
