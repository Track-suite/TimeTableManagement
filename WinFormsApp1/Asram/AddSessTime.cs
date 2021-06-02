using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Thakshila;
using Ttable.Asram;
using WinFormsApp1;

namespace Ttable.Asram
{
    public partial class AddSessTime : UserControl
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-45UO70S;Initial Catalog=ITPM;Integrated Security=True");
        SqlCommand cmd, cmd1;
        SqlDataAdapter adapt;
        SqlDataReader Myread;

        //ID variable used in Updating and Deleting Record  
        int ID = 0;
        public AddSessTime()
        {
            InitializeComponent();

            Fill_Combo();
            ShowData();
        }
        private void Fill_Combo()
        {
            String Query = "Select * from Location ;";
                String Query2 = "Select * from session ;";



            cmd = new SqlCommand(Query, con);
            cmd1 = new SqlCommand(Query2, con);

            try
            {
                con.Open();
                Myread = cmd.ExecuteReader();


                while (Myread.Read())
                {

                    String Bname = Myread.GetString("RoomName")+" "+Myread.GetString("RoomType");
                    comboBox1.Items.Add(Bname);

                }
                con.Close();

                con.Open();
                Myread = cmd1.ExecuteReader();

                while (Myread.Read())
                {

                    // String yname = Myread.GetString("AcademicYearSemester");
                    // comboBox1.Items.Add(yname);

                    String gno = Myread.GetInt32("id").ToString();
                    comboBox2.Items.Add(gno);



                }
                con.Close();





            }
            catch (Exception ex)
            {
                throw ex;
            }
            //Room 
            comboBox1.Items.Insert(0, "--Select--");
            comboBox1.Focus();

            //Session ID
            comboBox2.Items.Insert(0, "--Select--");
            comboBox2.Focus();


           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)//Nothing selected
            {
                MessageBox.Show("You must select Room ", "Alert");
            }
            else if (comboBox2.SelectedIndex == -1)
            {

                MessageBox.Show("You must select a SessionID ", "Alert");
            }
            else if (comboBox3.SelectedIndex == -1)
            {

                MessageBox.Show("You must select a Sub Group ", "Alert");
            }
            else if (textBox1.Text == "")
            {

                MessageBox.Show("You must Enter Start Time ", "Alert");

            }
            else if (textBox1.Text == "")
            {

                MessageBox.Show("You must Enter End Time ", "Alert");

            }
            else
            {
                string TimeL = textBox1.Text + "-" + textBox2.Text;
                cmd1 = new SqlCommand("insert into [dbo].[Table_SessionTime](Room,SessionID,Days,Time) values(@room,@Sid,@day,@time)", con);
                con.Open();

                cmd1.Parameters.AddWithValue("@room", comboBox1.Text.ToString());
                cmd1.Parameters.AddWithValue("@Sid", comboBox2.Text.ToString());
                cmd1.Parameters.AddWithValue("@day", comboBox3.Text.ToString());

                cmd1.Parameters.AddWithValue("@Time", TimeL);

                cmd1.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
            }
            ShowData();//show database
            ClearData();
        }
        //show database
        private void ShowData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Table_SessionTime", con);
            adapt.Fill(dt);
            SessionData.DataSource = dt;

            con.Close();
        }

        private void SessionData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(SessionData.Rows[e.RowIndex].Cells[0].Value.ToString());
            comboBox1.Text = SessionData.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBox2.Text = SessionData.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBox3.Text = SessionData.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox1.Text = SessionData.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox2.Text = SessionData.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)//Nothing selected
            {
                MessageBox.Show("You must select a Room ", "Alert");
            }
            else if (comboBox2.SelectedIndex == -1)
            {

                MessageBox.Show("You must select a Session ID ", "Alert");
            }
            else if (comboBox3.SelectedIndex == -1)
            {

                MessageBox.Show("You must select a Day ", "Alert");
            }
            else if (textBox1.Text == "")
            {

                MessageBox.Show("You must Enter Time ", "Alert");

            }
            else if (textBox2.Text == "")
            {

                MessageBox.Show("You must Enter Time ", "Alert");

            }
            else
            {
                cmd = new SqlCommand("update [dbo].[Table_SessionTime] set Room=@room,SessionID=@Sid,Days=@day,Time=@time where ID=@id", con);
                con.Open();
                String Timep = textBox1.Text + "-" + textBox2.Text;
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@room", comboBox1.Text.ToString());
                cmd.Parameters.AddWithValue("@Sid", comboBox2.Text.ToString());
                cmd.Parameters.AddWithValue("@day", comboBox3.Text.ToString());
                cmd.Parameters.AddWithValue("@time", Timep);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");

                con.Close();
                ShowData();

            }
            ClearData();
        }
        //Clear button method
        private void ClearData()
        {

            comboBox3.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("delete [dbo].[Table_SessionTime] where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                ShowData();
                ClearData();

            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void AddSessTime_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
           ParallelSessioncs add = new ParallelSessioncs();
            add.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
           ConsecutiveSession add = new ConsecutiveSession();
            add.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
           AddSession add = new AddSession();
            add.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            NonOverlapping add = new NonOverlapping();
            add.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
