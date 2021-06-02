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
    public partial class ParallelSessioncs : Form
    {
        //Database Connection-------------------
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-45UO70S;Initial Catalog=ITPM;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public ParallelSessioncs()
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

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
            LectureName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TagName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            GroupId.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            SubjectName.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            NoStudents.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            Duration.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            RoomName.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            SessionID.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            Days.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            Time.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
           ConsecutiveSession add = new ConsecutiveSession();
            add.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSessTime add = new AddSessTime();
            add.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
           NonOverlapping add = new NonOverlapping();
            add.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSession add = new AddSession();
            add.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into ParallelSession1(parLectureName,parTagName,parGroupId,parSubjectName,parNoStudents,Duration ,parRoomName,parSessionID,parDays,parTime) values(@parlecturename,@partagname,@pargroupid1,@parsubjectname,@parnostudents,@parduration,@parroomname,@parsessionid,@days,@partime)", con);
            con.Open();
           
            cmd.Parameters.AddWithValue("@parlecturename", LectureName.Text);
            cmd.Parameters.AddWithValue("@partagname", TagName.Text);
            cmd.Parameters.AddWithValue("@pargroupid1", GroupId.Text);
            cmd.Parameters.AddWithValue("@parsubjectname", SubjectName.Text);
            cmd.Parameters.AddWithValue("@parnostudents", NoStudents.Text);
            cmd.Parameters.AddWithValue("@parduration", Duration.Text);
            cmd.Parameters.AddWithValue("@parroomname", RoomName.Text);
            cmd.Parameters.AddWithValue("@parsessionid", SessionID.Text);
            cmd.Parameters.AddWithValue("@days", Days.Text);
            cmd.Parameters.AddWithValue("@partime", Time.Text);


            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully");

            DisplayData();
        }

        private void ParallelSessioncs_Load(object sender, EventArgs e)
        {

        }

        private void view_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewParallel add = new ViewParallel();
            add.Show();
        }
    }
}
