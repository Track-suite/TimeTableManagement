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
    public partial class manageLocation : Form
    {
        int dataId;
        public manageLocation()
        {
            InitializeComponent();
            var select = "SELECT * FROM location";
            var c = new SqlConnection(@"Data Source=DESKTOP-45UO70S;Initial Catalog=ITPM;Integrated Security=True"); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);
            

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show((string)dataGridView1.SelectedRows[0].Cells[0].Value); 
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
           // MessageBox.Show(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()); 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataId = Int16.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()); 
            textBoxBuilding.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxRoom.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxCapacity.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

            String roomType = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (roomType == "Laboratory")
            {
                radioButtonLab.Checked = true;

            }
            else
            {
                radioButtonLecture.Checked = true;
            }

        }

        private void buttonManageUpdate_Click(object sender, EventArgs e)
        {

            string RoomType = "";
            if (radioButtonLecture.Checked)
                RoomType = "Lecture Hall";
            else if (radioButtonLab.Checked)
                RoomType = "Laboratory";
            //Database connection
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-45UO70S;Initial Catalog=ITPM;Integrated Security=True");
            SqlCommand cmd;


            cmd = new SqlCommand("update location set BuildingName=@BuildingName,RoomName=@RoomName,RoomType=@RoomType,Capacity=@Capacity where id=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@BuildingName", textBoxBuilding.Text.ToString());
            cmd.Parameters.AddWithValue("@RoomName", textBoxRoom.Text.ToString());
            cmd.Parameters.AddWithValue("@RoomType", RoomType);
            cmd.Parameters.AddWithValue("@Capacity", textBoxCapacity.Text.ToString());
            cmd.Parameters.AddWithValue("@id", dataId);


            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully");
            manageLocation m1 = new manageLocation();
            this.Hide();
            m1.Show();

        }

        private void buttonManageDelete_Click(object sender, EventArgs e)
        {
            
            //Database connection
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-45UO70S;Initial Catalog=ITPM;Integrated Security=True");
            SqlCommand cmd;


            cmd = new SqlCommand("delete from location  where id=@id", con);
            con.Open();
          
            cmd.Parameters.AddWithValue("@id", dataId);


            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully");
            manageLocation m1 = new manageLocation();
            this.Hide();
            m1.Show();
        }

        private void buttonManangeClear_Click(object sender, EventArgs e)
        {
            textBoxBuilding.Text = "";
            textBoxRoom.Text = "";
            textBoxCapacity.Text = "";
            radioButtonLab.Checked = false;
            radioButtonLecture.Checked = false;
        }



        private void button8_Click(object sender, EventArgs e)
        {
      
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
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

        private void button10_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LocationTimeTable add = new LocationTimeTable();
            add.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            NotAvilableTime add = new NotAvilableTime();
            add.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
            AddLocations frm = new AddLocations();
            frm.Show();
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
    }
}
