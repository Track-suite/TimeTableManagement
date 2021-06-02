using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using WinFormsApp1.Thakshila;
using Ttable.Asram;

namespace WinFormsApp1
{
    public partial class Statistics : Form
    {
       
        
        AddLocations a1 = null;
        //FormStatic s1 = null;
        int totalVal = 100;

        private bool isCollapsed;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
         (
             int nLeftRect,     // x-coordinate of upper-left corner
             int nTopRect,      // y-coordinate of upper-left corner
             int nRightRect,    // x-coordinate of lower-right corner
             int nBottomRect,   // y-coordinate of lower-right corner
             int nWidthEllipse, // height of ellipse
             int nHeightEllipse // width of ellipse
         );

        public Statistics()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-45UO70S;Initial Catalog=ITPM;Integrated Security=True");
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT count(id) as total FROM location", conn);
            
            
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    textBox7.Text = String.Format("{0}", reader["total"]);
                    totalVal = Int16.Parse(String.Format("{0}", reader["total"]));
                }
            }

            SqlCommand command1 = new SqlCommand("SELECT count(LectureName) as total FROM lecture", conn);

            
            using (SqlDataReader reader = command1.ExecuteReader())
            {
                if (reader.Read())
                {
                    textBox4.Text = String.Format("{0}", reader["total"]);
                }
            }

            SqlCommand command2 = new SqlCommand("SELECT count(SubjectCode) as total FROM subject", conn);

            
            using (SqlDataReader reader = command2.ExecuteReader())
            {
                if (reader.Read())
                {
                    textBox6.Text = String.Format("{0}", reader["total"]);
                }
            }

            SqlCommand command3 = new SqlCommand("SELECT count(id) as total FROM Table_student", conn);

            // int result = command.ExecuteNonQuery();
            using (SqlDataReader reader = command3.ExecuteReader())
            {
                if (reader.Read())
                {
                    textBox5.Text = String.Format("{0}", reader["total"]);
                }
            }

            SqlCommand command4 = new SqlCommand("SELECT TOP 1 * FROM lecture ORDER BY id DESC", conn);

            // int result = command.ExecuteNonQuery();
            using (SqlDataReader reader = command4.ExecuteReader())
            {
                if (reader.Read())
                {
                    textBox1.Text = String.Format("{0}", reader["LectureName"]);
                }
            }

            SqlCommand command5 = new SqlCommand("SELECT TOP 1 * FROM table_generate ORDER BY id DESC ", conn);

            // int result = command.ExecuteNonQuery();
            using (SqlDataReader reader = command5.ExecuteReader())
            {
                if (reader.Read())
                {
                    textBox2.Text = String.Format("{0}", reader["GroupId"]);
                }
            }

            SqlCommand command6 = new SqlCommand("SELECT TOP 1 * FROM subject ORDER BY id DESC ", conn);

            // int result = command.ExecuteNonQuery();
            using (SqlDataReader reader = command6.ExecuteReader())
            {
                if (reader.Read())
                {
                    textBox3.Text = String.Format("{0}", reader["SubjectName"]);
                }
            }


            SqlCommand command7 = new SqlCommand("select count(*) as total from location where RoomType='Laboratory'", conn);

            // int result = command.ExecuteNonQuery();
            using (SqlDataReader reader = command7.ExecuteReader())
            {
                if (reader.Read())
                {
                    Double lab = float.Parse(String.Format("{0}", reader["total"]));
                    Double ans = Math.Round((Double) (lab / totalVal),2);
                    int fin = (int) (ans*100);
                    
                    progressBar2.Value = fin;
                }
            }


            SqlCommand command8 = new SqlCommand("select count(*) as total from location where RoomType='Lecture Hall'", conn);

            // int result = command.ExecuteNonQuery();
            using (SqlDataReader reader = command8.ExecuteReader())
            {
                if (reader.Read())
                {
                    Double lab = float.Parse(String.Format("{0}", reader["total"]));
                    Double ans = Math.Round((Double)(lab / totalVal), 2);
                    int fin = (int)(ans * 100);
                    progressBar1.Value = fin;
                }
            }

            conn.Close();
        }
        public Statistics(AddLocations a)
        {
            InitializeComponent();
            this.a1 = a;
        }

       /* public Statistics(FormStatic s)
        {
            InitializeComponent();
            this.s1 = s;
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            //panel2.Height = 46;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Hide();
            AddSubjects add = new AddSubjects();
            add.Show();  

            sidePanel.Height = button4.Height;
            sidePanel.Top = button4.Top;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form3 add = new Form3();
            add.Show(); 
            
            sidePanel.Height = button5.Height;
            sidePanel.Top = button5.Top;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            
            
            sidePanel.Height = button7.Height;
            sidePanel.Top = button7.Top;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            LocationTimeTable add = new LocationTimeTable();
            add.Show(); 
            
            sidePanel.Height = button10.Height;
            sidePanel.Top = button10.Top;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            AddLectures add = new AddLectures();
            add.Show(); 
            sidePanel.Height = button2.Height;
            sidePanel.Top = button2.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            addWorkingDays add = new addWorkingDays();
            add.Show(); 
            sidePanel.Height = button1.Height;
            sidePanel.Top = button1.Top;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button8.Height;
            sidePanel.Top = button8.Top;

            /*
            if (panel2.Height == 140)
            {

                panel2.Height = 46;

            }
            else
            {

                panel2.Height = 140;
            }*/
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (a1 == null || a1.IsDisposed)
            {
                a1 = new AddLocations();
            }
            a1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 add = new Form1();
            add.Show(); 
            
            sidePanel.Height = button3.Height;
            sidePanel.Top = button3.Top;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button9.Height;
            sidePanel.Top = button9.Top;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            Statistics add = new Statistics();
            add.Show();
            /*if (s1 == null || s1.IsDisposed)
            {
                //s1 = new FormStatic();
            }
            s1.Show();
            this.Hide();*/
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            NotAvilableTime add = new NotAvilableTime();
            add.Show();
        }


        /* private void timer1_Tick(object sender, EventArgs e)
         {
             if (isCollapsed)
             {

                 panel3.Height += 10;
                 if (panel3.Size == panel3.MaximumSize)
                 {
                     timer1.Stop();
                     isCollapsed = false;

                 }

             }
             else 
             {
                 panel3.Height -= 10;
                 if (panel3.Size == panel3.MinimumSize)
                 {
                     timer1.Stop()
  ;
                     isCollapsed = true;

                 }
             }
         }*/
    }
}
