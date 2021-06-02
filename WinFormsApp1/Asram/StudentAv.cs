using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1;

namespace Ttable.Asram
{
    public partial class StudentAv : UserControl
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-45UO70S;Initial Catalog=ITPM;Integrated Security=True");
        SqlCommand cmd,cmd1;
        SqlDataAdapter adapt;
        SqlDataReader Myread ;

        String timeValue ;
        int no;
        int ID = 0;
        public StudentAv()
        {
            InitializeComponent();
            Fill_Combo();
            //Fill_Combo1();
            ShowData();//show database
            }
       private void Fill_Combo()
        {
            String Query = "Select * from Table_Student ;";
            String Query1 = "Select * from Table_Generate ;";

            //cmd = new SqlCommand("Select AcademicYearSemester from Table_Student ", con);
            cmd = new SqlCommand(Query, con);
           cmd1 = new SqlCommand(Query1, con);
           
            try
            {
                con.Open();
                Myread = cmd.ExecuteReader();
               

                while (Myread.Read()) {

                   String yname = Myread.GetString("AcademicYearSemester");
                   comboBox1.Items.Add(yname);

                    
                    

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

            }
            catch (Exception ex)
            {
                throw ex;
            }
            //year
            comboBox1.Items.Insert(0, "--Select--");
            comboBox1.Focus();

            //group number
            comboBox2.Items.Insert(0, "--Select--");
            comboBox2.Focus();


            //Sub group number
            comboBox3.Items.Insert(0, "--Select--");
            comboBox3.Focus();

        }
        //Clear button method
        private void ClearData()
        {

            comboBox3.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;

            StdTime.Text = "";

        }

        private void button13_Click(object sender, EventArgs e)
        {
           

        }

        private void button14_Click(object sender, EventArgs e)
        {
           
        }

        private void UpdateWorks_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            if (!NotAvilableTime.Instance.pnlContainer.Controls.ContainsKey("manageAvailablity"))
            {

                manageAvailablity mng = new manageAvailablity();
                mng.Dock = DockStyle.Fill;
                NotAvilableTime.Instance.pnlContainer.Controls.Add(mng);


            }
            NotAvilableTime.Instance.pnlContainer.Controls["manageAvailablity"].BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!NotAvilableTime.Instance.pnlContainer.Controls.ContainsKey("RoomAv"))
            {

                RoomAv room = new RoomAv();
                room.Dock = DockStyle.Fill;
                NotAvilableTime.Instance.pnlContainer.Controls.Add(room);


            }
            NotAvilableTime.Instance.pnlContainer.Controls["RoomAv"].BringToFront();
        }

        private void label8_Click(object sender, EventArgs e)
        {

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

                MessageBox.Show("You must select a Day ", "Alert");
            }
            else if (StdTime.Text == "")
            {

                MessageBox.Show("You must Enter Time ", "Alert");

            }
            else
            {
                String Timed = comboBox4.Text + "," + StdTime.Text;
                no = 2;
                cmd1 = new SqlCommand("insert into Table_StudentNA(Year,_Group,Sub_Group,Time) values(@year,@group,@SubGroup,@Time)", con);
                con.Open();

                cmd1.Parameters.AddWithValue("@year", comboBox1.Text.ToString());
                cmd1.Parameters.AddWithValue("@group", comboBox2.Text.ToString());
                cmd1.Parameters.AddWithValue("@SubGroup", comboBox3.Text.ToString());
             
                cmd1.Parameters.AddWithValue("@Time", Timed);

                cmd1.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
            }
            ShowData();//show database

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            ClearData();
        }
        //retrieve datas from Database and show 
        private void ShowData()
        {
            con.Open();
             DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from [dbo].[Table_StudentNA]", con);
            adapt.Fill(dt);
            NoStudentTable.DataSource = dt;

            con.Close();
        }

        private void NoStudentTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(NoStudentTable.Rows[e.RowIndex].Cells[0].Value.ToString());
            comboBox1.Text = NoStudentTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBox2.Text = NoStudentTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBox3.Text = NoStudentTable.Rows[e.RowIndex].Cells[3].Value.ToString();
            StdTime.Text = NoStudentTable.Rows[e.RowIndex].Cells[4].Value.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
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

                MessageBox.Show("You must select a Day ", "Alert");
            }
            else if (StdTime.Text == "")
            {

                MessageBox.Show("You must Enter Time ", "Alert");

            }
            else { 
            cmd = new SqlCommand("update Table_StudentNA set Year=@year,_Group =@group,Sub_Group =@Sgroup,Time=@time where ID=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", ID);
            cmd.Parameters.AddWithValue("@year", comboBox1.Text.ToString());
            cmd.Parameters.AddWithValue("@group", comboBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@Sgroup", comboBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@time", StdTime.Text);


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
                cmd = new SqlCommand("delete Table_StudentNA where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                ShowData();

            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
