using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using WinFormsApp1.Thakshila;
using Ttable.Asram;

namespace WinFormsApp1
{
    public partial class AddLocations : Form
    {
        private AddLocations addLocations;
        public static string managelocation = "";

        

        manageLocation m1 = null;
        public AddLocations()
        {
            InitializeComponent();
            
        }
        public static string[,] LocationDetails = new string[100, 4];
        private string FileName = "";
        int NoOfUsers = 0;
        public AddLocations(manageLocation m)
        {
            InitializeComponent();
            this.m1 = m;
        }
        private void ResetControls()
        {
            this.textBoxBuilding.Text = "";
            this.textBoxRoom.Text = "";
            this.textBoxCapacity.Text = "";
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

            this.Hide();
            AddLectures add = new AddLectures();
            add.Show();
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
            /*{
                Statistics f1 = new Statistics();
                this.Hide();
                f1.Show();
            }*/
        }

        private void buttonView_Click_1(object sender, EventArgs e)
        {
           
            if (m1 == null || m1.IsDisposed)
            {
                //SqlConnection conn = new SqlConnection("Data Source=LAPTOP-AU11U311;Initial Catalog=timetablemanagement;Integrated Security=True");
                m1 = new manageLocation();
            }
            m1.Show();
            this.Hide();
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            string RoomType = "";
            if (radioButtonLecture.Checked)
                RoomType = "Lecture Hall";
            else if (radioButtonLab.Checked)
                RoomType = "Laboratory";

            LocationDetails[NoOfUsers, 0] = textBoxBuilding.Text;
            LocationDetails[NoOfUsers, 1] = textBoxRoom.Text;
            LocationDetails[NoOfUsers, 2] = RoomType;
            LocationDetails[NoOfUsers, 3] = textBoxCapacity.Text.ToString();

           
            NoOfUsers++;

            //Database connection
            SqlConnection con = new SqlConnection("Server = localhost; Database = timetablemanagement; Integrated Security = True;");
            SqlCommand cmd;
           

            cmd = new SqlCommand("Insert into location(BuildingName,RoomName,RoomType,Capacity)  values(@BuildingName,@RoomName,@RoomType,@Capacity)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@BuildingName", textBoxBuilding.Text.ToString());
            cmd.Parameters.AddWithValue("@RoomName", textBoxRoom.Text.ToString());
            cmd.Parameters.AddWithValue("@RoomType", RoomType);
            cmd.Parameters.AddWithValue("@Capacity", textBoxCapacity.Text.ToString());

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully");

           
            //this.Hide();
            
           
            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ResetControls();
        }
    }
}
