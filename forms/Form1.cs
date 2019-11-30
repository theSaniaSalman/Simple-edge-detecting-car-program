using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int j = 3,i = 226, k = 609;
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (j < 1110&&k==609)
            {
                pictureBox1.Image = Image.FromFile(@"D:\bcar1.png");
                pictureBox1.Location = new Point(j, 609);
                j++;
            }
            if (j==1110 && k!=182)
            {
                pictureBox1.Image = Image.FromFile(@"D:\bcar.jpg");
                pictureBox1.Location = new Point(1110, k);
                k--;
            }
            if (k==182&&j!=209)
            {
                pictureBox1.Image = Image.FromFile(@"D:\bcar2.png");
                pictureBox1.Location = new Point(j, 182);
                j--;
            }
            if (j==209&&k>=174&&k!=609)
            {
                pictureBox1.Image = Image.FromFile(@"D:\bcar3.png");
                pictureBox1.Location = new Point(209,k);
                k++;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            }
        private void timer3_Tick(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
    }
}

