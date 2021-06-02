using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using Ttable.Asram;

namespace WinFormsApp1.Thakshila
{
    public partial class Form1 : Form
    {

        //Database Connection-------------------
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-45UO70S;Initial Catalog=ITPM;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        //ID variable used i updating and deleting-------------------
        //int id = 0;

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

        public Form1()
        {
            InitializeComponent();
           
        }

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
            sidePanel.Height = button5.Height;
            sidePanel.Top = button5.Top;

            this.Hide();
            Form3 add = new Form3();
            add.Show();
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
            this.Hide();
           NotAvilableTime add = new NotAvilableTime();
            add.Show();




            sidePanel.Height = button8.Height;
            sidePanel.Top = button8.Top;


           /* if (panel2.Height == 140)
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
            this.Hide();
           AddLocations add = new AddLocations();
            add.Show();
            sidePanel.Height = button6.Height;
            sidePanel.Top = button6.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button3.Height;
            sidePanel.Top = button3.Top;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Statistics add = new Statistics();
            add.Show(); 
            
            sidePanel.Height = button9.Height;
            sidePanel.Top = button9.Top;
        }

        private void btnManageStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 add = new Form2();
            add.Show();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into Table_Generate(GroupId,SubGroupId) values(@groupid,@subgroupid)", con);
            con.Open();
            
            cmd.Parameters.AddWithValue("@groupid", txtGroupId.Text);
            cmd.Parameters.AddWithValue("@subgroupid", txtSubId.Text);





            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully student group details added!!");
            con.Close();


        }

        private void txtSubId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGroupId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSub_Click(object sender, EventArgs e)
        {

        }

        private void lblGroup_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerateID_Click(object sender, EventArgs e)
        {
            String yearsemester = comboacademic.Text;
            String programme = comboProgramme.Text;
            int groupnumber = Convert.ToInt32(numericgroup.Value);
            int subgroupnumber = Convert.ToInt32(numericsub.Value);

            txtGroupId.Text = yearsemester + "." + programme + "." + groupnumber;
            txtSubId.Text = yearsemester +"."+ programme +"."+ groupnumber + "." + subgroupnumber;

        }

        private void btnStudentClear_Click(object sender, EventArgs e)
        {

        }

        private void btnStudentSave_Click(object sender, EventArgs e)
        {

            cmd = new SqlCommand("insert into Table_Student(AcademicYearSemester,Programme,GroupNumber,SubGroupNumber) values(@academicyearsemester,@programme,@groupnumber,@subgroupnumber)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@academicyearsemester", comboacademic.Text);
            cmd.Parameters.AddWithValue("@programme", comboProgramme.Text);
            cmd.Parameters.AddWithValue("@groupnumber", numericgroup.Value);
            cmd.Parameters.AddWithValue("@subgroupnumber",numericsub.Value);
           



            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully");
           
        }

       

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSubGroup_Click(object sender, EventArgs e)
        {

        }

        private void lblGroupNum_Click(object sender, EventArgs e)
        {

        }

        private void lblProgramme_Click(object sender, EventArgs e)
        {

        }

        private void lblAcademic_Click(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
