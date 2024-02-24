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
    public partial class budgeting : Form
    {
        public static string grid;
        public budgeting()
        {
            InitializeComponent();
        }

        private void homebutton_Click(object sender, EventArgs e)
        {
            // switch to home 

            Home HomeForm = new Home();
            HomeForm.Show();
            this.Close();
        }

        private void gunaAdvenceButton10_Click(object sender, EventArgs e)
        {
            // log out from Application & open login
            MessageBox.Show($"Logged out !");

            login loginForm = new login();
            loginForm.Show();

            this.Close();
        }

        private void homebutton_Click_1(object sender, EventArgs e)
        {
            // open home close form now

            Cursor.Current = Cursors.WaitCursor;

            Home HomeForm = new Home();
            HomeForm.Show();
            
    
            HomeForm.Load += (home, login) =>
            {
                
                Cursor.Current = Cursors.Default;
                this.Show();
            };
            this.Close();


        }

        private void gunaPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton19_Click(object sender, EventArgs e)
        {
            // open form Formulaire

            formulaire formul = new formulaire();
            formul.Show();
        }
    }
}
