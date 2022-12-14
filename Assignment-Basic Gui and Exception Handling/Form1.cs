/*
 * Daniel Groveman
 * MS539 Programming Concepts
 * I thought this project would take about an hour, but I think it took more like 4 hours, but most of that was problems utilizing Github and VisualStudio kept not working.  
 * Once I discovered fixes for those problems, the actual programming of this was probably about two hours.  A lot of that time, was trying to figure out how to nest my error handlers. 
 * Definitely a good learning experience.
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Assignment_Basic_Gui_and_Exception_Handling
{
    public partial class startMenu : Form
    {
        public startMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            int result;
            string str = listLevel.Text;
            try
            {
               result = int.Parse (str);  //Checks to see if a valid integer was added
                
                // If else section checks that a level between 1 and 5 were selected
                if (result > 5)
                {
                    MessageBox.Show("Please enter a number between 1 and 5");
                }    
                else if (result < 1)
                {
                    MessageBox.Show("Please enter a number between 1 and 5");
                }
                else
                {
                    MessageBox.Show("Thank you for selecting your level");
                }           
            }
            catch //Message displays if not a valid number (Not an integer)
            {
                MessageBox.Show("Not a valid number");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)  //Displays message box with comment on color chosen
        {
            if (Purple.Checked == true)
            {
                MessageBox.Show("What a cool color for a snake");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (Blue.Checked == true)
            {
                MessageBox.Show("One of my favorite colors");
            }
        }

        private void Green_CheckedChanged(object sender, EventArgs e)
        {
             if (Green.Checked == true)
            {
                MessageBox.Show("Ah. the classic snake color");
            }
        }

        private void Black_CheckedChanged(object sender, EventArgs e)
        {
            if (Black.Checked == true)
            {
                MessageBox.Show("Spooky");
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void buttonName_Click(object sender, EventArgs e)  
        {
            string fName = nameBox.Text;

            MessageBox.Show("Welcome " + fName); //On pressing enter displays Welcome and Name entered in text box
        }
    }
}
