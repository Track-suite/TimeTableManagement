using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WinFormsApp1.Thakshila
{
    public partial class ConsecutiveSession : Form
    {
        //Database Connection-------------------
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-45UO70S;Initial Catalog=ITPM;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        public ConsecutiveSession()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from session", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

        }

        private void ConsecutiveSession_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            LectureName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TagName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            GroupId.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            SubjectName.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            NoStudents.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            Duration.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            RoomName.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            day.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into Consecutive(LectureName,TagName,GroupId,SubjectName,NoStudents,Duration ,RoomName,day1) values(@lecturename,@tagname,@groupid1,@subjectname,@nostudents,@duration,@roomname,@day)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", Id.Text);
            cmd.Parameters.AddWithValue("@lecturename", LectureName.Text);
            cmd.Parameters.AddWithValue("@tagname", TagName.Text);
            cmd.Parameters.AddWithValue("@groupid1", GroupId.Text);
            cmd.Parameters.AddWithValue("@subjectname", SubjectName.Text);
            cmd.Parameters.AddWithValue("@nostudents", NoStudents.Text);
            cmd.Parameters.AddWithValue("@duration", Duration.Text);
            cmd.Parameters.AddWithValue("@roomname", RoomName.Text);
            cmd.Parameters.AddWithValue("@day", day.Text);


            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully");

            DisplayData();


            //String mainconn =ConfigurationManager.ConnectionStrings[""]
            /*SqlConnection sqlconn = new SqlConnection(@"Data Source=DESKTOP-45UO70S;Initial Catalog=ITPM;Integrated Security=True");
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                bool chkboxselected = Convert.ToBoolean(dr.Cells["chk"].Value);
                if (chkboxselected)
                {
                    string sqlquery = "Insert into [dbo].[Consecutive] values(@LectureName,@TagName,@GroupId,@SubjectName,@NoStudents,@Duration,@RoomName,@day) ";
                    SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);

                    sqlconn.Open();
                    sqlcomm.Parameters.AddWithValue("@LectureName",dr.Cells[2].Value);
                    sqlcomm.Parameters.AddWithValue("@TagName", dr.Cells[3].Value);
                    sqlcomm.Parameters.AddWithValue("@GroupId", dr.Cells[4].Value);
                    sqlcomm.Parameters.AddWithValue("@SubjectName", dr.Cells[4].Value);
                    sqlcomm.Parameters.AddWithValue("@NoStudents", dr.Cells[5].Value);
                    sqlcomm.Parameters.AddWithValue("@Duration", dr.Cells[6].Value);
                    sqlcomm.Parameters.AddWithValue("@RoomName", dr.Cells[7].Value);
                    sqlcomm.Parameters.AddWithValue("@day", dr.Cells[8].Value);

                    //sqlconn.Open();
                    sqlcomm.ExecuteNonQuery();
                    sqlconn.Close();
                }

                MessageBox.Show( " Consecutive session added Successfully");
            }*/
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSession add = new AddSession();
            add.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewConsecutive add = new ViewConsecutive();
            add.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            ParallelSessioncs add = new ParallelSessioncs();
            add.Show();
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
    }
}
