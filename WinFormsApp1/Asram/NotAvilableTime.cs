using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1;

using WinFormsApp1.Thakshila;

namespace Ttable.Asram
{
    public partial class NotAvilableTime : Form
    {
        static NotAvilableTime _obj;

        public static NotAvilableTime Instance
        {
            get {


                if (_obj == null) {

                    _obj = new NotAvilableTime();
                     
                
                }
                return _obj;
            } 
        
        }

        public Panel pnlContainer
        {
            get { return context; }
            set { context = value; }
        }
        //button11
        public Button avialbe
        {
            get { return button11; }
            set { button11 = value; }
        }

        public NotAvilableTime()
        {
            InitializeComponent();

            manageAvailablity mng = new manageAvailablity();
            mng.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(mng);
        }

        private void NotAvilableTime_Load(object sender, EventArgs e)
        {
            button11.Visible = true;
            _obj = this;
            
        }
        //Hide the Drop down Menu
        private void hidepanel1()
        {



            if (panel4.Height == 145)
            {

                panel4.Height = 46;

            }

        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            addWorkingDays add = new addWorkingDays();
            add.Show();


           
            
            sidePanel.Height = button1.Height;
            sidePanel.Top = button1.Top;

            //hide panel
            hidepanel1();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button9.Height;
            sidePanel.Top = button9.Top;
            //hide panel
            hidepanel1();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //pnlContainer.Controls["manageAvailablity"].BringToFront();
           

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

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            LocationTimeTable add = new LocationTimeTable();
            add.Show();
            sidePanel.Height = button10.Height;
            sidePanel.Top = button10.Top;

            //hide panel
            hidepanel1();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button7.Height;
            sidePanel.Top = button7.Top;
            //hide panel
            hidepanel1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddLectures add = new AddLectures();
            add.Show(); 
            
            sidePanel.Height = button2.Height;
            sidePanel.Top = button2.Top;

            //hide panel
            hidepanel1();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSubjects add = new AddSubjects();
            add.Show(); 
            
            sidePanel.Height = button4.Height;
            sidePanel.Top = button4.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 add = new Form1();
            add.Show(); 
            
            sidePanel.Height = button3.Height;
            sidePanel.Top = button3.Top;

            //hide panel
            hidepanel1();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 add = new Form3();
            add.Show(); 
            
            sidePanel.Height = button5.Height;
            sidePanel.Top = button5.Top;

            //hide panel
            hidepanel1();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddLocations add = new AddLocations();
            add.Show(); 
            
            sidePanel.Height = button6.Height;
            sidePanel.Top = button6.Top;

            //hide panel
            hidepanel1();
        }

        private void manageAvailablity1_Load(object sender, EventArgs e)
        {

        }

        private void context_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            manageAvailablity mng = new manageAvailablity();
            mng.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(mng);
            mng.BringToFront();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

            AddSessTime mng = new AddSessTime();
            mng.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(mng);
            mng.BringToFront();



        }
    }
}
