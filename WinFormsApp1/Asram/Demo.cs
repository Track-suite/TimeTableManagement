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
using WinFormsApp1.Thakshila;

namespace Ttable
{
    public partial class Demo : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-45UO70S;Initial Catalog=ITPM;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        //ID variable used in Updating and Deleting Record  
        int ID = 0;
        int time = 0;
        int full = 0;
        String timeValue;
        String MinValue;
        public Demo()
        {
            InitializeComponent();
            ShowData();
        }
        //method to hide panel
        private void hidepanel1()
        {



            if (panel4.Height == 145)
            {

                panel4.Height = 46;

            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
           
        }

        private void Demo_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           

            ID = Convert.ToInt32(dataTable.Rows[e.RowIndex].Cells[0].Value.ToString());
            noWork.Text = dataTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            
            Hours.Text = dataTable.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void checkBoxSelector()
        {
            throw new NotImplementedException();
        }

        private void ShowData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from AddWork", con);
            adapt.Fill(dt);
            dataTable.DataSource = dt;
            
            con.Close();
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            addWorkingDays add = new addWorkingDays();
            add.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("delete AddWork where ID=@id", con);
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (noWork.Value == 0) {

                MessageBox.Show("Select Number of Working Days");
            }
            else {

                String s = "";
                foreach (Control c in this.Controls)
                {

                    if (c is CheckBox)
                    {

                        CheckBox b = (CheckBox)c;
                        if (b.Checked)
                        {

                            s = b.Text + "," + s;

                        }
                        s = s.TrimEnd(',');
                    }
                }
                if (min30.Checked)
                {

                    time = 30;
                    MinValue = " " + String.Format("{0:0}", time) + "Minutes";


                }
                timeValue = timeValue + MinValue;
                cmd = new SqlCommand("update AddWork set NWorkDay=@name,Days=@Wday,TimePday=@Hours where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@name", noWork.Text);
                cmd.Parameters.AddWithValue("@Wday", s);
                cmd.Parameters.AddWithValue("@Hours", timeValue);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");

                con.Close();
               
                ClearData();
            }
        }

        private void ClearData()
        {
            Hours.Value = 0;
            noWork.Value = 0;
            foreach (Control c in Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }

            }
            min30.Checked = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void noWork_ValueChanged(object sender, EventArgs e)
        {
            if (noWork.Value >= 8)
            {
                noWork.Value = 0;
                MessageBox.Show("Working Days Exceeded please select valid Days!");
            }
        }

        private void Hours_ValueChanged(object sender, EventArgs e)
        {
            full = (int)Hours.Value;
            timeValue = String.Format("{0:0}", full) + label4.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            NotAvilableTime add = new NotAvilableTime();
            add.Show();

            sidePanel.Height = button11.Height;
            sidePanel.Top = panel4.Top;

            //method to hide panel
            
            if (panel4.Height == 145)
            {

                panel4.Height = 46;

            }
            else
            {

                panel4.Height = 145;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            addWorkingDays add = new addWorkingDays();
            add.Show(); 
            
            //method to hide panel
            hidepanel1();

            sidePanel.Height = button1.Height;
            sidePanel.Top = button1.Top;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddLectures add = new AddLectures();
            add.Show(); 
            
            sidePanel.Height = button2.Height;
            sidePanel.Top = button2.Top;

            //method to hide panel
            hidepanel1();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSubjects add = new AddSubjects();
            add.Show(); 
            
            sidePanel.Height = button4.Height;
            sidePanel.Top = button4.Top;

            //method to hide panel
            hidepanel1();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 add = new Form1();
            add.Show(); 
            
            sidePanel.Height = button3.Height;
            sidePanel.Top = button3.Top;

            //method to hide panel
            hidepanel1();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 add = new Form3();
            add.Show(); 
            
            sidePanel.Height = button5.Height;
            sidePanel.Top = button5.Top;


            //method to hide panel
            hidepanel1();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddLocations add = new AddLocations();
            add.Show(); 
            
            sidePanel.Height = button6.Height;
            sidePanel.Top = button6.Top;


            //method to hide panel
            hidepanel1();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button7.Height;
            sidePanel.Top = button7.Top;

            //method to hide panel
            hidepanel1();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            LocationTimeTable add = new LocationTimeTable();
            add.Show();

            sidePanel.Height = button10.Height;
            sidePanel.Top = button10.Top;

            //method to hide panel
            hidepanel1();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Statistics add = new Statistics();
            add.Show(); 
            
            sidePanel.Height = button9.Height;
            sidePanel.Top = button9.Top;

            //method to hide panel
            hidepanel1();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            NotAvilableTime add = new NotAvilableTime();
            add.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}

