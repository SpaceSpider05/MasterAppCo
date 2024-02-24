using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterAppCo
{
    public partial class Home : Form
    {
        public static  string Title;
        public Home()
        {
            InitializeComponent();
            // function show username from login to home
            label10.Text = Title;
            this.gunaLabel41.Text =
               "© 2024 Spider.exe. All rights reserved.";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton10_Click(object sender, EventArgs e)
        { 
           // close application & open login
            this.Close();
            login loginForm = new login();
            loginForm.Show();
            

        }

        private void gunaGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaAdvenceButton9_Click(object sender, EventArgs e)
        {

        }

        private void gunaLinePanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaAdvenceButton8_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton7_Click(object sender, EventArgs e)
        {

        }

        private void gunaLinePanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            // open budgeting

            budgeting Form = new budgeting();
            Form.Show();
            this.Hide();
        }

        private void gunaLinePanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {

        }

        private void homebutton_Click(object sender, EventArgs e)
        {

        }

        private void gunaLinePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLabel1_Click_1(object sender, EventArgs e)
        {
            gunaAdvenceButton1.Text = DateTime.Now.ToLongDateString();



        }

        private void gunaLinePanel8_Paint(object sender, PaintEventArgs e)
        {


        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel25_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel28_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel21_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel40_Click(object sender, EventArgs e)
        {
            
        }
    }

}
