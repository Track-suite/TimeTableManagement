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

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
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

            panel2.Height = 46;

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
            sidePanel.Height = button4.Height;
            sidePanel.Top = button4.Top;
        }

        private void button5_Click(object sender, EventArgs e)
        {
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
            sidePanel.Height = button10.Height;
            sidePanel.Top = button10.Top;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button2.Height;
            sidePanel.Top = button2.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button1.Height;
            sidePanel.Top = button1.Top;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button8.Height;
            sidePanel.Top = button8.Top;


            if (panel2.Height == 140)
            {

                panel2.Height = 46;

            }
            else
            {

                panel2.Height = 140;
            }
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
            sidePanel.Height = button9.Height;
            sidePanel.Top = button9.Top;
        }
    }
}
