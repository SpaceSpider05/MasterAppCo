using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class login : Form
    {
       

        public login()
        {
            InitializeComponent();
            this.AcceptButton = gunaAdvenceButton1;

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void BodyLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {

            string username = user.Text;
                string password = pass.Text;

               
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter both username and password.");
                    return; 
                }

                this.Hide();

                if (username == user.Text && password == "123456")
                {
                   Home.Title = username;


                
                  
                this.Hide();
                Home f = new Home();
                f.Show();


            }

            else
                {
                
               MessageBox.Show("Invalid username or password.");
                    
                }

            }
            

        private void gunaPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaWinSwitch1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

