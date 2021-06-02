using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Ttable.Asram
{
    public partial class manageAvailablity : UserControl
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-45UO70S;Initial Catalog=ITPM;Integrated Security=True");
        SqlCommand cmd, cmd1,cmd2;
        SqlDataAdapter adapt;
        SqlDataReader Myread;

        int ID = 0;
        bool someNumber;

        public manageAvailablity()
        {
            InitializeComponent();
            Fill_Combo();
            ShowData();
        }
        private void Fill_Combo()
        {
            String Query = "Select * from Lecture ;";
            String Query1 = "Select * from Table_Generate ;";
            String Query2 = "Select * from session ;";

            //cmd = new SqlCommand("Select AcademicYearSemester from Table_Student ", con);
            cmd = new SqlCommand(Query, con);
            cmd1 = new SqlCommand(Query1, con);
            cmd2 = new SqlCommand(Query2, con);

            try
            {
                con.Open();
                Myread = cmd.ExecuteReader();


                while (Myread.Read())
                {

                    String Lname = Myread.GetString("LectureName");
                    comboBox1.Items.Add(Lname);




                }
                con.Close();

                con.Open();
                Myread = cmd1.ExecuteReader();

                while (Myread.Read())
                {

                    // String yname = Myread.GetString("AcademicYearSemester");
                    // comboBox1.Items.Add(yname);

                    String gno = Myread.GetString("GroupId");
                    comboBox2.Items.Add(gno);
                    String Sbgno = Myread.GetString("SubGroupId");
                    comboBox3.Items.Add(Sbgno);


                }
                con.Close();

                con.Open();
                Myread = cmd2.ExecuteReader();

                while (Myread.Read())
                {

                    // String yname = Myread.GetString("AcademicYearSemester");
                    // comboBox1.Items.Add(yname);

                    String gno = Myread.GetInt32("id").ToString();
                    comboBox4.Items.Add(gno);
                  


                }
                con.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            //Lecture Name
            comboBox1.Items.Insert(0, "--Select--");
            comboBox1.Focus();

            //group number
            comboBox2.Items.Insert(0, "--Select--");
            comboBox2.Focus();


            //Sub group number
            comboBox3.Items.Insert(0, "--Select--");
            comboBox3.Focus();

            //Session ID
            comboBox4.Items.Insert(0, "--Select--");
            comboBox4.Focus();

        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (!NotAvilableTime.Instance.pnlContainer.Controls.ContainsKey("StudentAv"))
            {

                StudentAv std = new StudentAv();
                std.Dock = DockStyle.Fill;
                NotAvilableTime.Instance.pnlContainer.Controls.Add(std);

            
            }
            NotAvilableTime.Instance.pnlContainer.Controls["StudentAv"].BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!NotAvilableTime.Instance.pnlContainer.Controls.ContainsKey("RoomAv"))
            {

                RoomAv room = new RoomAv();
                room.Dock = DockStyle.Fill;
                NotAvilableTime.Instance.pnlContainer.Controls.Add(room);


            }
            NotAvilableTime.Instance.pnlContainer.Controls["RoomAv"].BringToFront();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)//Nothing selected
            {
                MessageBox.Show("You must select a Year ", "Alert");
            }
            else if (comboBox2.SelectedIndex == -1)
            {

                MessageBox.Show("You must select a Group ", "Alert");
            }
            else if (comboBox3.SelectedIndex == -1)
            {

                MessageBox.Show("You must select a Sub Group ", "Alert");
            }
            else if (comboBox4.SelectedIndex == -1)
            {

                MessageBox.Show("You must select Session ID ", "Alert");
            }
            else if (comboBox5.SelectedIndex == -1)
            {

                MessageBox.Show("You must select  Day ", "Alert");
            }
            else if (textBox1.Text == "")
            {

                MessageBox.Show("You must Enter Time ", "Alert");

            }
            else
            {
                String Timed = comboBox5.Text + "," + textBox1.Text;
                cmd1 = new SqlCommand("insert into [dbo].[Table_LecturerNA](Lecturer,Group_,Sub_Group,SessionID,Time) values(@lecturer,@group,@subGrp,@Sid,@time)", con);
                con.Open();

                cmd1.Parameters.AddWithValue("@lecturer", comboBox1.Text.ToString());
                cmd1.Parameters.AddWithValue("@group", comboBox2.Text.ToString());
                cmd1.Parameters.AddWithValue("@subGrp", comboBox3.Text.ToString());
                cmd1.Parameters.AddWithValue("@Sid", comboBox4.Text.ToString());
                cmd1.Parameters.AddWithValue("@time", Timed);

                cmd1.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
            }
            ShowData();//show database
            ClearData();
        }

        private void DataLec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(DataLec.Rows[e.RowIndex].Cells[0].Value.ToString());
            comboBox1.Text = DataLec.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBox2.Text = DataLec.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBox3.Text = DataLec.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBox4.Text = DataLec.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox1.Text = DataLec.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)//Nothing selected
            {
                MessageBox.Show("You must select a Year ", "Alert");
            }
            else if (comboBox2.SelectedIndex == -1)
            {

                MessageBox.Show("You must select a Group ", "Alert");
            }
            else if (comboBox3.SelectedIndex == -1)
            {

                MessageBox.Show("You must select a Sub Group ", "Alert");
            }
            else if (comboBox4.SelectedIndex == -1)
            {

                MessageBox.Show("You must select a Session ID ", "Alert");
            }
            else if (comboBox5.SelectedIndex == -1)
            {

                MessageBox.Show("You must select a Day ", "Alert");
            }
            else if (textBox1.Text == "")
            {

                MessageBox.Show("You must Enter Time ", "Alert");

            }
            else
            {
                String Timed = comboBox5.Text + "," + textBox1.Text;

                cmd = new SqlCommand("update [dbo].[Table_LecturerNA] set Lecturer=@lecturer,Group_=@group,Sub_Group=@subGrp,SessionID=@Sid,Time=@time where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@lecturer", comboBox1.Text.ToString());
                cmd.Parameters.AddWithValue("@group", comboBox2.Text.ToString());
                cmd.Parameters.AddWithValue("@subGrp", comboBox3.Text.ToString());
                cmd.Parameters.AddWithValue("@Sid", comboBox4.Text.ToString());
                cmd.Parameters.AddWithValue("@time",Timed);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");

                con.Close();
                ShowData();

            }
            ClearData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("delete [dbo].[Table_LecturerNA] where ID=@id", con);
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

        //show database
        private void ShowData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Table_LecturerNA", con);
            adapt.Fill(dt);
            DataLec.DataSource = dt;

            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void manageAvailablity_Load(object sender, EventArgs e)
        {

        }

        //Clear data
        private void ClearData()
        {

            comboBox3.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;

            textBox1.Text = "";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
