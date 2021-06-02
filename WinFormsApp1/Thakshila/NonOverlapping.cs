using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Ttable.Asram;

namespace WinFormsApp1.Thakshila
{
    public partial class NonOverlapping : Form
    {
        //Database Connection-------------------
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-45UO70S;Initial Catalog=ITPM;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public NonOverlapping()
        {
            InitializeComponent();
            DisplayData();
        }
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select LectureName,TagName,GroupId,SubjectName,NoStudents,Duration,RoomName,SessionID,Days,Time from session,Table_SessionTime", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

        }
        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            ParallelSessioncs add = new ParallelSessioncs();
            add.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NLectureName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            NTagName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            GroupId1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            NSubjectName.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            NNoStudents.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            NDuration.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            NRoomName.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            NSessionID.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            NDays.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            NTime.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void NonOverlapping_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into NonoverlappingSession(NonLectureName,NonTagName,NonGroupId,NonSubjectName,NonNoStudents,NonDuration ,NonRoomName,NonSessionID,NonDays,NonTime) values(@parlecturename,@partagname,@pargroupid1,@parsubjectname,@parnostudents,@parduration,@parroomname,@parsessionid,@days,@partime)", con);
            con.Open();

            cmd.Parameters.AddWithValue("@parlecturename", NLectureName.Text);
            cmd.Parameters.AddWithValue("@partagname", NTagName.Text);
            cmd.Parameters.AddWithValue("@pargroupid1", GroupId1.Text);
            cmd.Parameters.AddWithValue("@parsubjectname", NSubjectName.Text);
            cmd.Parameters.AddWithValue("@parnostudents", NNoStudents.Text);
            cmd.Parameters.AddWithValue("@parduration", NDuration.Text);
            cmd.Parameters.AddWithValue("@parroomname", NRoomName.Text);
            cmd.Parameters.AddWithValue("@parsessionid", NSessionID.Text);
            cmd.Parameters.AddWithValue("@days", NDays.Text);
            cmd.Parameters.AddWithValue("@partime", NTime.Text);


            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully");

            DisplayData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewNonoverlapping add = new ViewNonoverlapping();
            add.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
           ConsecutiveSession add = new ConsecutiveSession();
            add.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSessTime add = new AddSessTime();
            add.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
           AddSession add = new AddSession();
            add.Show();
        }
    }
}
