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
    }
}
