using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MasterAppCo
{
    public partial class formulaire : Form
    {
        public formulaire()
        {
            InitializeComponent();
        }

        private void gunaLineTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }

        private void gunaRadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaLineTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void formulaire_Load(object sender, EventArgs e)

        {        //dataGridView1.Columns.Add( [for program] , [for user] )

            dataGridView1.Columns.Add("first_name", "First Name"); 
            dataGridView1.Columns.Add("middle_name", "Middle Name");
            dataGridView1.Columns.Add("last_name", "Last Name");
            dataGridView1.Columns.Add("gender", "Gender");
            dataGridView1.Columns.Add("birth", "Day og Birth");
            dataGridView1.Columns.Add("offer", "Offers");
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            budgeting o= new budgeting();
            
                
                dataGridView1.Rows.Add(  /* rows*/
             gunaLineTextBox1.Text, gunaLineTextBox2.Text, gunaLineTextBox3.Text, comboBox1.Text,
             gunaDateTimePicker1.Text, checkedListBox1.Text);/* rows*/
        }
        
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            /*empty*/ // clear all text boxes
            gunaLineTextBox1.Text = "";
            gunaLineTextBox2.Text = "";
            gunaLineTextBox3.Text = "";
            comboBox1.Text = "";
            gunaDateTimePicker1.Text = "";
            checkedListBox1.Text = "";
            /**/

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            //drop the table

            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

            }
            else
            {
                MessageBox.Show("Please select a client!");
            }

        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // make id start from  {step}

            int step = 1;
            this.dataGridView1.Rows[e.RowIndex].Cells["ID"].Value =(e.RowIndex+step).ToString();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            // close the formulaire 
            budgeting ff = new budgeting();
            ff.Show();
            this.Hide();
        }
    }
}