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

namespace WinFormsApp1.Thakshila
{
    public partial class LocationTimeTable : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-45UO70S;Initial Catalog=ITPM;Integrated Security=True");
        SqlCommand cmd, cmd1;
        SqlDataAdapter adapt;
        SqlDataReader Myread;
        public LocationTimeTable()
        {
            InitializeComponent();
            Fill_Combo();
        }
        private void Fill_Combo()
        {
            String Query = "Select* from location ;";




            cmd = new SqlCommand(Query, con);

            try
            {
                con.Open();
                Myread = cmd.ExecuteReader();


                while (Myread.Read())
                {

                    String Bname = Myread.GetString("RoomName");
                    comboBox1.Items.Add(Bname);






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






        }
        public void Showdata()
        {
            /* retrieving the data into the grid view*/
            string query1 = null;
            /*if (query1 == null)
            {
                //query1 = "select Lecture,Tags,Groups,Subject,Duration,day from session order by Duration ";
            }
            else*/

            query1 = "select LectureName,TagName,GroupId,SubjectName,Duration,day,Time,RoomName ts from session,Table_SessionTime ts where RoomName LIKE '%" + comboBox1.Text + "%' order by Time";
            ;
            SqlCommand cmd = new SqlCommand(query1, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);

            con.Close();

            DataTable newData = new DataTable();

            newData.Columns.Add("Time", typeof(String));
            newData.Columns.Add("Monday", typeof(String));
            newData.Columns.Add("Tuesday", typeof(String));
            newData.Columns.Add("Wednesday", typeof(String));
            newData.Columns.Add("Thursday", typeof(String));
            newData.Columns.Add("Friday", typeof(String));
            
            String[] timeSlot = new String[] { "08.30-09.30", "09.30-10.30", "10.30-11.30", "11.30-12.30", "12.30-1.30", "01.30-02.30", "02.30-03.30", "03.30-04.30", "04.30-05.30" };

            for (int i = 0; i < timeSlot.Length; i++)
            {
                newData.Rows.Add(new object[] { timeSlot[i], "--", "--", "--", "--", "--" });
            }

            foreach (DataRow row in dt.Rows)
            {
                string ss = row[0] + ";" + row[1] + "\n" + row[2] + ":" + row[3] + ":" + row[4] + ":" + row[5];
                string col = null;

                if (row[5].Equals("Monday"))
                {
                    col = "Monday";
                }
                else if (row[5].Equals("Tuesday"))
                {
                    col = "Tuesday";
                }
                else if (row[5].Equals("Wednesday"))
                {
                    col = "Wednesday";
                }
                else if (row[5].Equals("Thursday"))
                {
                    col = "Thursday";
                }
                else if (row[5].Equals("Friday"))
                {
                    col = "Friday";
                }

                for (int i = 0; i < timeSlot.Length; i++)
                {
                    if (row[6].Equals(timeSlot[i]))
                    {
                        newData.Rows[i][col] = ss;
                        break;
                    }
                }
            }


            dataGridView1.DataSource = newData;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            /*con.Open();
            adapt = new SqlDataAdapter("select * from TTGenerate1 where Monday like '" + comboBox1.Text + "%' OR Tuesday like '%" + comboBox1.Text + "%' OR  Wednesday like '%" + comboBox1.Text + "%' OR Thursday like '%" + comboBox1.Text + "%' OR Friday like '%" + comboBox1.Text + "%'", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();

            */
            Showdata();




            MessageBox.Show(comboBox1.Text + "\'s Time Table Successfully");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentTimeTable add = new StudentTimeTable();
            add.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            lectureTimeTable add = new lectureTimeTable();
            add.Show();
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
            AddLocations add= new AddLocations();
            add.Show();


        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            NotAvilableTime add = new NotAvilableTime();
            add.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Statistics add = new Statistics();
            add.Show();
        }

        private void LocationTimeTable_Load(object sender, EventArgs e)
        {

        }
    }
}
