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
    public partial class AddLectures : Form
    {
        private AddLectures addLocation;
        public static string managelocation = "";
        ManageLectures m1 = null;
        AddSession f1 = null;
        AddSubjects s1 = null;
        public AddLectures()
        {
            InitializeComponent();
        }
        
        public static string[,] LocationDetails = new string[100, 8];
        private string FileName = "";
        int NoOfUsers = 0;
        
        public AddLectures(ManageLectures m)
        {
            InitializeComponent();
            this.m1 = m;
        }

        public AddLectures(AddSession f)
        {
            InitializeComponent();
            this.f1 = f;
        }
        public AddLectures(AddSubjects s)
        {
            InitializeComponent();
            this.s1 = s;
        }
        private void ResetControls()
        {/*
            this.textBoxBuilding.Text = "";
            this.textBoxRoom.Text = "";
            this.textBoxCapacity.Text = "";
            */
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddLocations_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelRoom_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            

        }

        private void textBoxCapacity_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
             

            this.Hide();
            NotAvilableTime add = new NotAvilableTime();
            add.Show();

            /* if (f1 == null || f1.IsDisposed)
             {
                 f1 = new AddSession();
             }
             f1.Show();
             this.Hide();*/
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            addWorkingDays add = new addWorkingDays();
            add.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            LocationTimeTable add = new LocationTimeTable();
            add.Show();
        }

        private void sidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 add = new Form3();
            add.Show();
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 add = new Form1();
            add.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
           AddLocations add = new AddLocations();
            add.Show();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
           Statistics add = new Statistics();
            add.Show();
        }

        private void buttonView_Click_1(object sender, EventArgs e)
        {
            if (m1 == null || m1.IsDisposed)
            {
                m1 = new ManageLectures();
            }
            m1.Show();
            this.Hide();
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            

            LocationDetails[NoOfUsers, 0] = textBoxName.Text;
            LocationDetails[NoOfUsers, 1] = textBoxID.Text.ToString();
            LocationDetails[NoOfUsers, 2] = comboBoxFaculty.Text;
            LocationDetails[NoOfUsers, 3] = comboBoxDepartment.SelectedItem.ToString();
            LocationDetails[NoOfUsers, 4] = comboBoxCenter.SelectedItem.ToString();
            LocationDetails[NoOfUsers, 5] = comboBoxBulding.SelectedItem.ToString();
            LocationDetails[NoOfUsers, 6] = comboBoxLevel.SelectedItem.ToString();
            LocationDetails[NoOfUsers, 7] = textBoxRank.Text.ToString();

            NoOfUsers++;

            //Database connection
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-45UO70S;Initial Catalog=ITPM;Integrated Security=True");
            SqlCommand cmd;


            cmd = new SqlCommand("Insert into Subject(Employeeid,LectureName,faculty,Department,Center,Building,Level,Rank)  values(@Employeeid,@LectureName,@faculty,@Department,@Center,@Building,@Level,@Rank)", con);
            con.Open();
           
            cmd.Parameters.AddWithValue("@Employeeid", textBoxID.Text.ToString());
            cmd.Parameters.AddWithValue("@LectureName", textBoxName.Text.ToString());
            cmd.Parameters.AddWithValue("@faculty", comboBoxFaculty.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Department", comboBoxDepartment.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Center", comboBoxCenter.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Building", comboBoxBulding.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Level", comboBoxLevel.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Rank", comboBoxLevel.SelectedItem.ToString() + "." + textBoxID.Text.ToString());
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully");



        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //ResetControls();
            textBoxID.Text = "";
            textBoxName.Text = "";
            textBoxRank.Text = "";
            comboBoxFaculty.Text = "";
            comboBoxDepartment.Text = "";
            comboBoxCenter.Text = "";
            comboBoxBulding.Text = "";
            comboBoxLevel.Text = "";
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxRank.Text = comboBoxLevel.SelectedItem.ToString() + "." + textBoxID.Text.ToString();
        }
    }
}
