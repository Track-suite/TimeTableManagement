using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ttable.Asram;
using Ttable;
using WinFormsApp1.Thakshila;

namespace WinFormsApp1
{
    public partial class addWorkingDays : Form
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
        public addWorkingDays()
        {
            InitializeComponent();
        }
        //Hide the Drop down Menu
        private void hidepanel1() {


            
            if (panel1.Height == 142)
            {

                panel1.Height = 46;

            }

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
           




            


        }

        private void addWorkingDays_Load(object sender, EventArgs e)
        {
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 view = new Form1();
            view.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSubjects add = new AddSubjects();
            add.Show(); 
            
            sidePanel.Height = button4.Height;
            sidePanel.Top = button4.Top;
            hidepanel1();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
           
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button13_Click_2(object sender, EventArgs e)
        {
            
        }

        private void button13_Click_3(object sender, EventArgs e)
        {
            
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            if (NWorkday.Value == 0  ) {
                MessageBox.Show("Select  Number Number of Working Days ");
            }
            else {


                String s = "";
                foreach (Control c in this.Controls)
                {

                    if (c is CheckBox)
                    {

                        CheckBox b = (CheckBox)c;
                        if (b.Checked == true)
                        {

                            s = b.Text + "," + s;

                        }
                        s = s.TrimEnd(',');

                    }
                }
                if (Min30.Checked) {

                    time = 30;
                    MinValue =" "+ String.Format("{0:0}", time) + "Minutes";


                }
                timeValue = timeValue + MinValue;

                cmd = new SqlCommand("insert into AddWork(NWorkDay,Days,TimePday) values(@numberdays,@Days,@Hours)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@numberdays", NWorkday.Text);
                cmd.Parameters.AddWithValue("@Days", s);
                cmd.Parameters.AddWithValue("@Hours", timeValue);


                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
            }
           

        }

        private void ClearData()
        {

            TimeP.Value = 0;
            NWorkday.Value = 0;
            foreach (Control c in Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }

            }
            Min30.Checked = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ClearData();

        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Demo dem = new Demo();
            dem.Show();
        }

        private void NWorkday_ValueChanged(object sender, EventArgs e)
        {
            if (NWorkday.Value >= 8)
            {
                NWorkday.Value = 0;
                MessageBox.Show("Working Days Exceeded please select valid Days!");
            }
        }

        private void Min30_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void TimeP_ValueChanged(object sender, EventArgs e)
        {
            full = (int)TimeP.Value  ;
            timeValue = String.Format("{0:0}", full)+"H"  ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 add = new Form1();
            add.Show();

            sidePanel.Height = button3.Height;
            sidePanel.Top = button3.Top;

            //Hide the Drop down Menu
            hidepanel1();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 add = new Form3();
            add.Show();

            sidePanel.Height = button5.Height;
            sidePanel.Top = button5.Top;

            //Hide the Drop down Menu
            hidepanel1();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddLocations add = new AddLocations();
            add.Show(); 
            
            sidePanel.Height = button6.Height;
            sidePanel.Top = button6.Top;

            //Hide the Drop down Menu
            hidepanel1();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button7.Height;
            sidePanel.Top = button7.Top;


            hidepanel1();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            NotAvilableTime add = new NotAvilableTime();
            add.Show();

            sidePanel.Height = button8.Height;
            sidePanel.Top = panel1.Top;

            //Drop down Menu 
            if (panel1.Height == 142)
            {

                panel1.Height = 46;

            }
            else
            {

                panel1.Height = 142;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Statistics add = new Statistics();
            add.Show(); 
            
            sidePanel.Height = button9.Height;
            sidePanel.Top = button9.Top;

            //Hide the Drop down Menu
            hidepanel1();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            LocationTimeTable add = new LocationTimeTable();
            add.Show(); 
            sidePanel.Height = button10.Height;
            sidePanel.Top = button10.Top;

          

            //Hide the Drop down Menu
            hidepanel1();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        private void button13_Click_4(object sender, EventArgs e)
        {

        }
    }
}
