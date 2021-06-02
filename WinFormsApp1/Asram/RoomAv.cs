using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ttable.Asram;
using WinFormsApp1;

namespace Ttable.Asram
{
   

    
    public partial class RoomAv : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-45UO70S;Initial Catalog=ITPM;Integrated Security=True");
        SqlCommand cmd, cmd1;
        SqlDataAdapter adapt;
        SqlDataReader Myread;

        //ID variable used in Updating and Deleting Record  
        int ID = 0;




        public RoomAv()
        {
            InitializeComponent();
            Fill_Combo();

            //show table
            ShowData();    
        }
        private void Fill_Combo()
        {
            String Query = "Select * from Location ;";
           

           
            cmd = new SqlCommand(Query, con);
            
            try
            {
                con.Open();
                Myread = cmd.ExecuteReader();


                while (Myread.Read())
                {

                    String Bname = Myread.GetString("BuildingName");
                    comboBox1.Items.Add(Bname);
                    
                    String rname = Myread.GetString("RoomName");
                    comboBox2.Items.Add(rname);

                    String Rtype = Myread.GetString("RoomType");
                    comboBox3.Items.Add(Rtype);




                }
                con.Close();

               

               

            }
            catch (Exception ex)
            {
                throw ex;
            }
            //building 
            comboBox1.Items.Insert(0, "--Select--");
            comboBox1.Focus();

            //Room Name
            comboBox2.Items.Insert(0, "--Select--");
            comboBox2.Focus();


            //Room Type
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
           
            textBox1.Text = "";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentAv upWork = new StudentAv();
            upWork.Show();


            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewDays_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click_1(object sender, EventArgs e)
        {

        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            addWorkingDays add = new addWorkingDays();
            add.Show();
                 
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            StudentAv upwork = new StudentAv();
            upwork.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ViewData()
        {
           
        }

        private void button14_Click_2(object sender, EventArgs e)
        {
            if (!NotAvilableTime.Instance.pnlContainer.Controls.ContainsKey("manageAvailabiltiy"))
            {

                manageAvailablity mng = new manageAvailablity();
                mng.Dock = DockStyle.Fill;
                NotAvilableTime.Instance.pnlContainer.Controls.Add(mng);


            }
            NotAvilableTime.Instance.pnlContainer.Controls["manageAvailablity"].BringToFront();
        }

        private void button13_Click_2(object sender, EventArgs e)
        {
            if (!NotAvilableTime.Instance.pnlContainer.Controls.ContainsKey("StudentAv"))
            {

                StudentAv std = new StudentAv();
                std.Dock = DockStyle.Fill;
                NotAvilableTime.Instance.pnlContainer.Controls.Add(std);


            }
            NotAvilableTime.Instance.pnlContainer.Controls["StudentAv"].BringToFront();

               
        }

        private void button15_Click_2(object sender, EventArgs e)
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

                MessageBox.Show("You must select a Date ", "Alert");
            }
            else if (textBox1.Text == "")
            {

                MessageBox.Show("You must Enter Time ", "Alert");

            }
            else
            {
                String Tdate = comboBox4.Text + "," + textBox1.Text;
                cmd1 = new SqlCommand("insert into Table_RoomNA(Building,Room,Room_Type,Time) values(@building,@room,@roomtype,@Time)", con);
                con.Open();

                cmd1.Parameters.AddWithValue("@building", comboBox1.Text.ToString());
                cmd1.Parameters.AddWithValue("@room", comboBox2.Text.ToString());
                cmd1.Parameters.AddWithValue("@roomtype", comboBox3.Text.ToString());

                cmd1.Parameters.AddWithValue("@Time",Tdate );

                cmd1.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
            }
            ShowData();//show database
        }
        private void ShowData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Table_RoomNA", con);
            adapt.Fill(dt);
            RoomData.DataSource = dt;

            con.Close();
        }

        private void RoomData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(RoomData.Rows[e.RowIndex].Cells[0].Value.ToString());
            comboBox1.Text = RoomData.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBox2.Text = RoomData.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBox3.Text = RoomData.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox1.Text = RoomData.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
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

                MessageBox.Show("You must select a Sub Group ", "Alert");
            }
            else if (textBox1.Text == "")
            {

                MessageBox.Show("You must Enter Time ", "Alert");

            }
            else
            {
                String TimeD = comboBox4.Text + "," + textBox1.Text;

                cmd = new SqlCommand("update [dbo].[Table_RoomNA] set Building=@building,Room=@room,Room_Type=@Rtype,Time=@time where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@building", comboBox1.Text.ToString());
                cmd.Parameters.AddWithValue("@room", comboBox2.Text.ToString());
                cmd.Parameters.AddWithValue("@Rtype", comboBox3.Text.ToString());
                cmd.Parameters.AddWithValue("@time", TimeD);


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
                cmd = new SqlCommand("delete [dbo].[Table_RoomNA] where ID=@id", con);
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

        private void button16_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
